public class ElementB : IElement
{
    public string Data { get; set; } = "Some data B";

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}