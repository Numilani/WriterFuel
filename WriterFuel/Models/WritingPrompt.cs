using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace WriterFuel.Data;

[Table("Prompts")]
public class WritingPrompt
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Pattern { get; set; }

    public List<IPatternComponent> GetComponents()
    {
        Regex rx = new Regex(@"({.[^}]*})", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        var matches = rx.Matches(Pattern);

        List<IPatternComponent> cpt = new();
        foreach (Match match in matches)
        {
            switch (match.Value)
            {
                case "{agent}":
                    cpt.Add(new AgentCard(""));
                    break;
                case "{anchor}":
                    cpt.Add(new AnchorCard(""));
                    break;
                case "{conflict}":
                    cpt.Add(new ConflictCard(""));
                    break;
                case "{engine}":
                    cpt.Add(new EngineCard(""));
                    break;
                default:
                    cpt.Add(new StringComponent(match.Value.Substring(2, match.Value.Length - 3)));
                    break;
            }
        }

        return cpt;
    }
}