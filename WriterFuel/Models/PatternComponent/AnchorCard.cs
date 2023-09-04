namespace WriterFuel.Data;

public class AnchorCard : CardComponent
{
    public List<AspectCard> Aspects { get; set; } = new();

    public AnchorCard(string parentPack, string cardText) : base(parentPack, cardText)
    {
    }

    public AnchorCard(string cardText) : base(cardText)
    {
    }
}