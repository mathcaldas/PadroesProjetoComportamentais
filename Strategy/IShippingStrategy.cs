public interface IShippingStrategy
{
    decimal Calculate(decimal orderValue);
}