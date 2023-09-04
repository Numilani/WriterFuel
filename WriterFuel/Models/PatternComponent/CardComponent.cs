using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WriterFuel.Data;

[Table("Cards")]
public class CardComponent : IPatternComponent
{
    [Key]
    public int Id { get; set; }
    public string? ParentPack { get; set; }
    public string CardText { get; set; }

    public CardComponent(string parentPack, string cardText)
    {
        ParentPack = parentPack;
        CardText = cardText;
    }

    public CardComponent(string cardText)
    {
        CardText = cardText;
    }
}