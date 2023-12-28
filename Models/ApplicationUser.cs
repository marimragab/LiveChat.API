using Microsoft.AspNetCore.Identity;

namespace LiveChat.API.Models
{
	public class ApplicationUser:IdentityUser
	{
        public ApplicationUser()
        {
            SentMessages=new HashSet<Message>();
			ReceivedMessages=new HashSet<Message>();
			UserConnections=new HashSet<UserConnection>();
        }


		public virtual ICollection<Message> SentMessages { get; set; }

		public virtual ICollection<Message> ReceivedMessages { get; set; }

		public virtual ICollection<UserConnection> UserConnections { get; set; }
	}
}
