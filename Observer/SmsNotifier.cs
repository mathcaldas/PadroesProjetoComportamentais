public class SmsNotifier : IObserver
{
    public void Update(string status)
    {
        Console.WriteLine($"SMS: Your order is now {status}.");
    }
}