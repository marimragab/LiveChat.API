
using LiveChat.API.Hubs;
using LiveChat.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
			builder.Services.AddSignalR();

			builder.Services.AddDbContext<ChatEntities>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
			});

			var app = builder.Build();

			using (var scope = app.Services.CreateScope())
			{
				var serviceProvider = scope.ServiceProvider;
				var dbContext = serviceProvider.GetRequiredService<ChatEntities>();

				var fakeUsers = TestDataGenerator.GenerateFakeUsers(10);
				dbContext.Users.AddRange(fakeUsers);
				dbContext.SaveChanges();

				var fakeMessages = TestDataGenerator.GenerateFakeMessages(20, fakeUsers);
				var fakeUserConnections = TestDataGenerator.GenerateFakeUserConnections(5, fakeUsers);

				dbContext.Messages.AddRange(fakeMessages);
				dbContext.UserConnections.AddRange(fakeUserConnections);

				dbContext.SaveChanges();
			}

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.MapHub<ChatHub>("/chat");
			app.MapControllers();

			app.Run();
		}
	}
}