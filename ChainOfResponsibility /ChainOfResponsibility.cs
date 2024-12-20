public abstract class DocumentHandler
{
    protected DocumentHandler _nextHandler;

    public DocumentHandler SetNext(DocumentHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public void Handle(string documentType)
    {
        if (CanHandle(documentType))
        {
            Process(documentType);
        }
        else if (_nextHandler != null)
        {
            _nextHandler.Handle(documentType);
        }
        else
        {
            Console.WriteLine($"Cannot process {documentType}.");
        }
    }

    protected abstract bool CanHandle(string documentType);
    protected abstract void Process(string documentType);
}

public class InvoiceHandler : DocumentHandler
{
    protected override bool CanHandle(string documentType)
    {
        return documentType == "Invoice";
    }

    protected override void Process(string documentType)
    {
        Console.WriteLine("Processing Invoice...");
    }
}

public class ReceiptHandler : DocumentHandler
{
    protected override bool CanHandle(string documentType)
    {
        return documentType == "Receipt";
    }

    protected override void Process(string documentType)
    {
        Console.WriteLine("Processing Receipt...");
    }
}

public class BillHandler : DocumentHandler
{
    protected override bool CanHandle(string documentType)
    {
        return documentType == "Bill";
    }

    protected override void Process(string documentType)
    {
        Console.WriteLine("Processing Bill...");
    }
}
