﻿namespace LiveChat.API.Models
{
	public class UserConnection
	{
		public int Id { get; set; }

		public string ConnectionId { get; set; }

		public string UserId { get; set; }
		public virtual ApplicationUser User { get; set; }
	}
}
