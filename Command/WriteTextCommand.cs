public class WriteTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly string _text;

    public WriteTextCommand(TextEditor editor, string text)
    {
        _editor = editor;
        _text = text;
    }

    public void Execute()
    {
        _editor.Write(_text);
    }

    public void Undo()
    {
        _editor.Delete(_text.Length);
    }
}