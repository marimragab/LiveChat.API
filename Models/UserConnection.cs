namespace LiveChat.API.Models
{
	public class UserConnection
	{
		public int Id { get; set; }

		public string ConnectionId { get; set; }

		public int UserId { get; set; }
		public virtual User User { get; set; }
	}
}
