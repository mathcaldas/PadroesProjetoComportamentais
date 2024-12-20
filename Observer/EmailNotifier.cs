public class EmailNotifier : IObserver
{
    public void Update(string status)
    {
        Console.WriteLine($"Email: Your order is now {status}.");
    }
}