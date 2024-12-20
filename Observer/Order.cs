public class Order : Observable
{
    private string _status;

    public void UpdateStatus(string status)
    {
        _status = status;
        Notify(_status);
    }
}