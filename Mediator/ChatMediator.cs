public class ChatMediator : IMediator
{
    private List<User> _users = new();

    public void RegisterUser(User user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users)
        {
            if (user != sender)
            {
                Console.WriteLine($"{sender.Name} to {user.Name}: {message}");
            }
        }
    }
}