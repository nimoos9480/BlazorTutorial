namespace GameBlazor.API.DTO
{
    public record class CreateGameDto
    (
        string Name,
        string Genre,
        decimal Price,
        DateOnly ReleaseDate
    );
}
