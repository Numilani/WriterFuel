namespace WriterFuel.Data;

public class AgentCard : CardComponent
{
    public List<AspectCard> Aspects { get; set; } = new();

    public AgentCard(string parentPack, string cardText) : base(parentPack, cardText)
    {
    }

    public AgentCard(string cardText) : base(cardText)
    {
    }
}