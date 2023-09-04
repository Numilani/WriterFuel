namespace WriterFuel.Data;

public class ConflictCard : CardComponent
{
    public ConflictCard(string parentPack, string cardText) : base(parentPack, cardText)
    {
    }

    public ConflictCard(string cardText) : base(cardText)
    {
    }
}