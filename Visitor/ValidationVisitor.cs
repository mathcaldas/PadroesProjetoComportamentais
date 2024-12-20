public class ValidationVisitor : IVisitor
{
    public void Visit(ElementA element)
    {
        Console.WriteLine($"Validating ElementA: {element.Data}");
    }

    public void Visit(ElementB element)
    {
        Console.WriteLine($"Validating ElementB: {element.Data}");
    }
}