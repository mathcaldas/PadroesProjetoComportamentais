public class TextEditor
{
    private string _content = "";

    public string Content 
    { 
        get { return _content; }
        set { _content = value; }
    }

    public void Write(string text)
    {
        _content += text;
        Console.WriteLine($"Current text: {_content}");
    }

    public void Delete(int length)
    {
        if (length <= _content.Length)
        {
            _content = _content[..^length];
        }
        Console.WriteLine($"Current text: {_content}");
    }
}