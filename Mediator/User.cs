public class User
{
    private readonly IMediator _mediator;
    public string Name { get; }

    public User(string name, IMediator mediator)
    {
        Name = name;
        _mediator = mediator;
        _mediator.RegisterUser(this);
    }

    public void SendMessage(string message)
    {
        _mediator.SendMessage(message, this);
    }
}