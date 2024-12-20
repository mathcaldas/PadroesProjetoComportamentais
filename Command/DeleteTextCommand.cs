public class DeleteTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly int _length;
    private string _deletedText;

    public DeleteTextCommand(TextEditor editor, int length)
    {
        _editor = editor;
        _length = length;
        _deletedText = "";
    }

    public void Execute()
    {
        if (_length <= _editor.Content.Length)
        {
            _deletedText = _editor.Content.Substring(_editor.Content.Length - _length);
            _editor.Delete(_length);
        }
    }

    public void Undo()
    {
        _editor.Write(_deletedText);
    }
}