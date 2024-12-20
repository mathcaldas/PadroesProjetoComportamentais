public class VendingMachine
{
    private IVendingMachineState _state;

    public VendingMachine()
    {
        _state = new NoCoinState();
    }

    public void SetState(IVendingMachineState state)
    {
        _state = state;
    }

    public void InsertCoin()
    {
        _state.InsertCoin(this);
    }

    public void SelectProduct()
    {
        _state.SelectProduct(this);
    }

    public void DispenseProduct()
    {
        _state.DispenseProduct(this);
    }
}