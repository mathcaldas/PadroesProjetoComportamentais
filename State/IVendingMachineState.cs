public interface IVendingMachineState
{
    void InsertCoin(VendingMachine machine);
    void SelectProduct(VendingMachine machine);
    void DispenseProduct(VendingMachine machine);
}