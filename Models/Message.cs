using System.ComponentModel.DataAnnotations.Schema;

namespace LiveChat.API.Models
{

	public enum MessageType
	{
		Text,
		Image,
		Document,
		Voice
	}

	public class Message
	{
		public int Id { get; set; }	

		public string Content { get; set; }=string.Empty;

		public DateTime Sended { get; set; }

		public bool IsDeleted { get; set; } = false;

		public bool Read { get; set; }=false;

		public string? AttachmentUrl { get; set; } 
		public MessageType MessageType { get; set; }

		public int SenderId { get; set; }
		public virtual User Sender { get; set; }

		public int ReceiverId { get; set; }
		public virtual User Receiver { get; set; }

	}
}
