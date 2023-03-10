// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SearchCoachApi.Models;

#nullable disable

namespace SearchCoachApi.Migrations
{
    [DbContext(typeof(SearchCoachApiContext))]
    [Migration("20230126190427_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SearchCoachApi.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            QuoteId = 1,
                            Text = "I do love a locker room. It smells like potential."
                        },
                        new
                        {
                            QuoteId = 2,
                            Text = "You know what the happiest animal on Earth is? It's a goldfish. You know why? It's got a 10-second memory."
                        },
                        new
                        {
                            QuoteId = 3,
                            Text = "Be curious, not judgmental."
                        },
                        new
                        {
                            QuoteId = 4,
                            Text = "I think that’s what it’s all about. Embracing change."
                        },
                        new
                        {
                            QuoteId = 5,
                            Text = "Don’t let the wisdom of age be wasted on you."
                        },
                        new
                        {
                            QuoteId = 6,
                            Text = "Hey, takin’ on a challenge is a lot like ridin’ a horse. If you’re comfortable while you’re doin’ it, you’re probably doin’ it wrong"
                        },
                        new
                        {
                            QuoteId = 7,
                            Text = "I have a real tricky time hearing folks that don’t believe in themselves."
                        },
                        new
                        {
                            QuoteId = 8,
                            Text = "You beating yourself up is like Woody Allen playing the clarinet. I don’t want to hear it."
                        },
                        new
                        {
                            QuoteId = 9,
                            Text = "You say impossible, but all I hear is ‘I’m possible."
                        },
                        new
                        {
                            QuoteId = 10,
                            Text = "Every disadvantage has its advantage."
                        },
                        new
                        {
                            QuoteId = 11,
                            Text = "Doing the right thing is never the wrong thing."
                        },
                        new
                        {
                            QuoteId = 12,
                            Text = "I suppose the best brand is being yourself."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
