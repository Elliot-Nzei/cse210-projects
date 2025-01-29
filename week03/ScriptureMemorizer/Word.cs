public class Word
{
    private string text;
    private bool isHidden;
    
    public Word(string text)
    {
        this.text = text;
        isHidden = false;
    }
    
    public string GetText() => isHidden ? new string('_', text.Length) : text;
    
    public void Hide() => isHidden = true;
    
    public bool IsHidden() => isHidden;
}