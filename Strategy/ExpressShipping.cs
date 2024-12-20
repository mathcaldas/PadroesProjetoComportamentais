public class ExpressShipping : IShippingStrategy
{
    public decimal Calculate(decimal orderValue)
    {
        return orderValue * 0.25m; // 25% do valor para entrega expressa
    }
}