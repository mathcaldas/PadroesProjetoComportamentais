public class ExportVisitor : IVisitor
{
    public void Visit(ElementA element)
    {
        Console.WriteLine($"Exporting ElementA: {element.Data}");
    }

    public void Visit(ElementB element)
    {
        Console.WriteLine($"Exporting ElementB: {element.Data}");
    }
}