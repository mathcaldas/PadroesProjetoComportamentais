public class SoldState : IVendingMachineState
{
    public void InsertCoin(VendingMachine machine)
    {
        Console.WriteLine("Please wait, dispensing product.");
    }

    public void SelectProduct(VendingMachine machine)
    {
        Console.WriteLine("Please wait, dispensing product.");
    }

    public void DispenseProduct(VendingMachine machine)
    {
        Console.WriteLine("Product dispensed.");
        machine.SetState(new NoCoinState());
    }
}