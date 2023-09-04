namespace WriterFuel.Data;

public class StringComponent : IPatternComponent
{
    public StringComponent(string text)
    {
        Text = text;
    }

    public string Text { get; set; }
}