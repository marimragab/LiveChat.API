
using LiveChat.API.Hubs;
using LiveChat.API.Models;
using LiveChat.API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace LiveChat.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddDbContext<ChatEntities>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
			});

			builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
				            .AddEntityFrameworkStores<ChatEntities>();

			builder.Services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme= JwtBearerDefaults.AuthenticationScheme;
				options.DefaultScheme= JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(options =>
			{
				options.SaveToken = true;
				options.RequireHttpsMetadata = false;
				options.TokenValidationParameters = new TokenValidationParameters()
				{
					ValidateIssuer=true,
					ValidIssuer = builder.Configuration["JWT:IssuerUrl"],
					ValidateAudience=true,
					ValidAudience= builder.Configuration["JWT:AudianceUrl"],
					IssuerSigningKey= new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:SecretKey"]))
			};
			});

			//builder.Services.AddScoped<UserService>();
			builder.Services.AddSignalR();

			builder.Services.AddCors(options =>
			{
				options.AddPolicy("AllowSpecificOrigin", builder =>
				{
					builder.WithOrigins("http://localhost:4200")
						   .AllowAnyHeader()
						   .AllowAnyMethod()
						   .AllowCredentials();
				});

			});

			var app = builder.Build();

			using (var scope = app.Services.CreateScope())
			{
				var serviceProvider = scope.ServiceProvider;
				var dbContext = serviceProvider.GetRequiredService<ChatEntities>();
				dbContext.Database.EnsureCreated();
			}

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseCors("AllowSpecificOrigin");

			app.UseAuthentication();

			app.UseAuthorization();

			app.MapControllers();
			app.MapHub<ChatHub>("/chat");

			app.Run();
		}
	}
}