public class PlayerMemento
{
    public int Position { get; }
    public int Health { get; }

    public PlayerMemento(int position, int health)
    {
        Position = position;
        Health = health;
    }
}