public abstract class Observable
{
    private List<IObserver> _observers = new();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    protected void Notify(string status)
    {
        foreach (var observer in _observers)
        {
            observer.Update(status);
        }
    }
}