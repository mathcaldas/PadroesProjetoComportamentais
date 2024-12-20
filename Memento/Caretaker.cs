public class Caretaker
{
    private PlayerMemento _memento;

    public void Save(PlayerMemento memento)
    {
        _memento = memento;
    }

    public void Restore(Player player)
    {
        if (_memento != null)
        {
            player.RestoreState(_memento);
        }
    }
}