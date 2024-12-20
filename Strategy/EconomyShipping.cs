public class EconomyShipping : IShippingStrategy
{
    public decimal Calculate(decimal orderValue)
    {
        return orderValue * 0.10m; // 10% do valor para entrega econômica
    }
}