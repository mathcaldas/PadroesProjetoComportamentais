public class NoCoinState : IVendingMachineState
{
    public void InsertCoin(VendingMachine machine)
    {
        Console.WriteLine("Coin inserted.");
        machine.SetState(new HasCoinState());
    }

    public void SelectProduct(VendingMachine machine)
    {
        Console.WriteLine("Please insert a coin first.");
    }

    public void DispenseProduct(VendingMachine machine)
    {
        Console.WriteLine("Please insert a coin first.");
    }
}