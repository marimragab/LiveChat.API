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

        public Message()
        {
            MessageDate = DateTime.Now;
        }

        public int Id { get; set; }	

		public string Content { get; set; }=string.Empty;

		public DateTime MessageDate { get; set; }

		public bool IsRead { get; set; }=false;

		public bool IsSeen { get; set; } = false;

		public bool IsSent { get; set; } = true;

		public bool IsDeleted { get; set; } = false;

		public string? AttachmentUrl { get; set; }

		public MessageType MessageType { get; set; } = MessageType.Text;

		public string SenderId { get; set; }
		public virtual ApplicationUser Sender { get; set; }

		public string ReceiverId { get; set; }
		public virtual ApplicationUser Receiver { get; set; }

	}
}
