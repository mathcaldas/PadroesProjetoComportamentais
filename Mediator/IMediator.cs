public interface IMediator
{
    void RegisterUser(User user);
    void SendMessage(string message, User sender);
}