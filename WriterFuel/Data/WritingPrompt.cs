namespace WriterFuel.Data;

public class WritingPrompt
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public List<PatternComponent> Pattern { get; set; }
}