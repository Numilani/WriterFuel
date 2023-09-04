using Microsoft.EntityFrameworkCore;

namespace WriterFuel.Data;

public class AppDbContext : DbContext
{
    protected AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    private DbSet<CardComponent> Cards { get; set; }
    public DbSet<AgentCard> Agents { get; set; }
    public DbSet<AnchorCard> Anchors { get; set; }
    public DbSet<AspectCard> Aspects { get; set; }
    public DbSet<ConflictCard> Conflicts { get; set; }
    public DbSet<EngineCard> Engines { get; set; }
    
    public DbSet<WritingPrompt> Prompts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CardComponent>()
            .HasDiscriminator<string>("CardType")
            .HasValue<AgentCard>("Agent")
            .HasValue<AnchorCard>("Anchor")
            .HasValue<AspectCard>("Aspect")
            .HasValue<ConflictCard>("Conflict")
            .HasValue<EngineCard>("Engine");
    }
}