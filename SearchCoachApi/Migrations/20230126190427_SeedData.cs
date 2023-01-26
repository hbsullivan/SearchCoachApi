using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SearchCoachApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Text" },
                values: new object[,]
                {
                    { 1, "I do love a locker room. It smells like potential." },
                    { 2, "You know what the happiest animal on Earth is? It's a goldfish. You know why? It's got a 10-second memory." },
                    { 3, "Be curious, not judgmental." },
                    { 4, "I think that’s what it’s all about. Embracing change." },
                    { 5, "Don’t let the wisdom of age be wasted on you." },
                    { 6, "Hey, takin’ on a challenge is a lot like ridin’ a horse. If you’re comfortable while you’re doin’ it, you’re probably doin’ it wrong" },
                    { 7, "I have a real tricky time hearing folks that don’t believe in themselves." },
                    { 8, "You beating yourself up is like Woody Allen playing the clarinet. I don’t want to hear it." },
                    { 9, "You say impossible, but all I hear is ‘I’m possible." },
                    { 10, "Every disadvantage has its advantage." },
                    { 11, "Doing the right thing is never the wrong thing." },
                    { 12, "I suppose the best brand is being yourself." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 12);
        }
    }
}
