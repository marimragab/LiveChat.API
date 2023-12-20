using Microsoft.EntityFrameworkCore;

namespace LiveChat.API.Models
{
	public class ChatEntities:DbContext
	{
        public ChatEntities() { }

        public ChatEntities(DbContextOptions options) : base(options) { }
        
        public DbSet<User> Users { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<UserConnection> UserConnections { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Message>()
						.HasOne(m => m.Sender)
						.WithMany(u => u.SentMessages)
						.HasForeignKey(m => m.SenderId)
						.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Message>()
						.HasOne(m => m.Receiver)
						.WithMany(u => u.ReceivedMessages)
						.HasForeignKey(m => m.ReceiverId)
						.OnDelete(DeleteBehavior.NoAction);


		}


	}
}
