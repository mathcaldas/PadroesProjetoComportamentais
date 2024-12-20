public class LocalShipping : IShippingStrategy
{
    public decimal Calculate(decimal orderValue)
    {
        return orderValue * 0.05m; // 5% do valor para entrega local
    }
}