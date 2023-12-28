using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LiveChat.API.Models
{
	public class ChatEntities:IdentityDbContext<ApplicationUser>
	{
        public ChatEntities() { }

        public ChatEntities(DbContextOptions options) : base(options) { }
        
        //public DbSet<User> Users { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<UserConnection> UserConnections { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Message>()
						.HasOne(m => m.Sender)
						.WithMany(u => u.SentMessages)
						.HasForeignKey(m => m.SenderId)
						.OnDelete(DeleteBehavior.Restrict)
		                .HasConstraintName("FK_Messages_AspNetUsers_SenderId"); ;
			 
			modelBuilder.Entity<Message>()
						.HasOne(m => m.Receiver)
						.WithMany(u => u.ReceivedMessages)
						.HasForeignKey(m => m.ReceiverId)
						.OnDelete(DeleteBehavior.Restrict)
		                .HasConstraintName("FK_Messages_AspNetUsers_ReceiverId");

			//var users = TestDataGenerator.GenerateFakeUsers(10);
			//for (int i = 0; i < users.Count; i++)
			//{
			//	users[i].Id = (i + 1);
			//}
			//modelBuilder.Entity<User>().HasData(users);

			//var messages = TestDataGenerator.GenerateFakeMessages(20, users);
			//for (int i = 0; i < messages.Count; i++)
			//{
			//	messages[i].Id = (i + 1);
			//}
			//modelBuilder.Entity<Message>().HasData(messages);

			//var userConnections = TestDataGenerator.GenerateFakeUserConnections(5, users);
			//for (int i = 0; i < userConnections.Count; i++)
			//{
			//	userConnections[i].Id = (i + 1);
			//}

			//modelBuilder.Entity<UserConnection>().HasData(userConnections);

		}


	}
}
