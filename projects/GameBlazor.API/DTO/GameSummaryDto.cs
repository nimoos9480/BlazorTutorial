namespace GameBlazor.API.DTO
{
    public record class GameSummaryDto
    (
        int Id,
        string Name,
        string Genre,
        decimal Price,
        DateOnly ReleaseDate
    );
}
