public class ElementA : IElement
{
    public string Data { get; set; } = "Some data A";

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}