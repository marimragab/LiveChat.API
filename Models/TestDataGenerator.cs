using Bogus;

namespace LiveChat.API.Models
{
	//public static class TestDataGenerator
	//{
	//	public static List<User> GenerateFakeUsers(int count)
	//	{
	//		Randomizer.Seed=new Random(1);
	//		var userFaker = new Faker<User>()
	//										.RuleFor(u => u.Name, f => f.Person.FullName)
	//										.RuleFor(u => u.Email, f => f.Person.Email)
	//										.RuleFor(u => u.Password, f => f.Internet.Password())
	//										.RuleFor(u => u.ImageUrl, f => f.Image.PicsumUrl())
	//                                        .RuleFor(u => u.UserType, f => f.PickRandom<UserType>());

	//		return userFaker.Generate(count);
	//	}

	//	public static List<Message> GenerateFakeMessages(int count, List<User> users)
	//	{
	//		var messageFaker = new Faker<Message>()
	//										.RuleFor(m => m.Content, f => f.Lorem.Sentence())
	//										.RuleFor(m => m.MessageDate, f => f.Date.Recent())
	//										.RuleFor(m => m.IsDeleted, f => f.Random.Bool())
	//										.RuleFor(m => m.IsRead, f => f.Random.Bool())
	//										.RuleFor(m => m.IsSent, f => f.Random.Bool())
	//										.RuleFor(m => m.AttachmentUrl, f => f.Internet.Url())
	//										.RuleFor(m => m.MessageType, f => f.PickRandom<MessageType>())
	//										.RuleFor(m => m.SenderId, f => f.PickRandom(users).Id)
	//										.RuleFor(m => m.ReceiverId, f => f.PickRandom(users).Id);

	//		return messageFaker.Generate(count);
	//	}

	//	public static List<UserConnection> GenerateFakeUserConnections(int count, List<User> users)
	//	{
	//		var connectionFaker = new Faker<UserConnection>()
	//										.RuleFor(c => c.ConnectionId, f => f.Random.Guid().ToString())
	//										.RuleFor(c => c.UserId, f => f.PickRandom(users).Id);

	//		return connectionFaker.Generate(count);
	//	}
	//}
}
