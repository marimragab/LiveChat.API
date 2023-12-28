using Newtonsoft.Json;
using static Bogus.DataSets.Name;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiveChat.API.Models
{
	
	public class User
	{
		public int Id { get;set; }

		public string Name { get; set; } = string.Empty;	

		public string Email { get; set; }=string.Empty;

		public string Password { get; set; } = string.Empty;

		public string ImageUrl { get; set; } = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freepik.com%2Ffree-photos-vectors%2Fdefault-user&psig=AOvVaw3ZrNSUCpAgH6NvldUSR9SM&ust=1703145084571000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCICXnoTEnYMDFQAAAAAdAAAAABAD";

		[Column("UserType")]
		public string Role
		{
			get { return UserType.ToString(); }
			private set { UserType = value.ParseEnum<UserType>(); }
		}

		[NotMapped]
		public UserType UserType { get; set; }

		public virtual List<Message> SentMessages { get; set; }

		public virtual List<Message> ReceivedMessages { get; set; }

		public virtual List<UserConnection> UserConnections { get; set; }	
	}

	public enum UserType
	{
		Admin,
		User,
	}

	public static class StringExtensions
	{
		public static T ParseEnum<T>(this string value)
		{
			return (T)Enum.Parse(typeof(T), value, true);
		}
	}
}
