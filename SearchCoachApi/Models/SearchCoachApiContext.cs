using Microsoft.EntityFrameworkCore;

namespace SearchCoachApi.Models
{
  public class SearchCoachApiContext : DbContext
  {
    public DbSet<Quote> Quotes { get; set; }

    public SearchCoachApiContext(DbContextOptions<SearchCoachApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Quote>()
        .HasData(
          new Quote { QuoteId = 1, Text = "I do love a locker room. It smells like potential." },
          new Quote { QuoteId = 2, Text = "You know what the happiest animal on Earth is? It's a goldfish. You know why? It's got a 10-second memory." },
          new Quote { QuoteId = 3, Text = "Be curious, not judgmental." },
          new Quote { QuoteId = 4, Text = "I think that’s what it’s all about. Embracing change." },
          new Quote { QuoteId = 5, Text = "Don’t let the wisdom of age be wasted on you." },
          new Quote { QuoteId = 6, Text = "Hey, takin’ on a challenge is a lot like ridin’ a horse. If you’re comfortable while you’re doin’ it, you’re probably doin’ it wrong" },
          new Quote { QuoteId = 7, Text = "I have a real tricky time hearing folks that don’t believe in themselves." },
          new Quote { QuoteId = 8, Text = "You beating yourself up is like Woody Allen playing the clarinet. I don’t want to hear it." },
          new Quote { QuoteId = 9, Text = "You say impossible, but all I hear is ‘I’m possible." },
          new Quote { QuoteId = 10, Text = "Every disadvantage has its advantage." },
          new Quote { QuoteId = 11, Text = "Doing the right thing is never the wrong thing." },
          new Quote { QuoteId = 12, Text = "I suppose the best brand is being yourself." }
        );
    }
  }
}
