public abstract class ReportGenerator
{
    // Template Method
    public void GenerateReport()
    {
        GenerateHeader();
        GenerateContent();
        Export();
    }

    protected void GenerateHeader()
    {
        Console.WriteLine("Generating report header...");
    }

    protected virtual void GenerateContent()
    {
        Console.WriteLine("Generating report content...");
    }

    protected abstract void Export();
}