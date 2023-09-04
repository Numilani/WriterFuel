namespace WriterFuel.Data;

public class EngineCard : CardComponent
{
    public List<AspectCard> Aspects { get; set; } = new();

    public EngineCard(string parentPack, string cardText) : base(parentPack, cardText)
    {
    }

    public EngineCard(string cardText) : base(cardText)
    {
    }
}