namespace GameBlazor.API.DTO
{
    public record class UpdateGameDto
    (
        string Name,
        string Genre,
        decimal Price,
        DateOnly ReleaseDate
    );
}
