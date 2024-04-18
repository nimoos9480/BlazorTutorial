using GameBlazor.API.DTO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string GetGameEndpointName = "GetName";

List<GameDto> games = [
    new(
            1,
            "Street Fighter II",
            "Fighting",
            19.99M,
            new DateOnly(1992, 7, 15)
        ),
        new(
            2,
            "Final Fantasy XIV",
            "Roleplaying",
            59.99M,
            new DateOnly(2010, 9, 30)
        ),
        new(
            3,
            "FIFA 23",
            "Sports",
            69.99M,
            new DateOnly(2022, 9, 27)
           ),
    ];

// GET: games
app.MapGet("games", () => games);

// GET: games/1
app.MapGet("games/{id}", (int id) => games.Find(game => game.Id == id))
       .WithName(GetGameEndpointName);  // ��������Ʈ�� �̸�("GetName")�� �ο� ==> �ش� ��������Ʈ�� ���� URL�� �����ϰų� �����ϴµ� ��� ����

//POST: games
app.MapPost("games", (CreateGameDto newGame) =>
{
    GameDto game = new(
        games.Count + 1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseDate
        );

    games.Add(game);

    return Results.CreatedAtRoute(GetGameEndpointName, new { id=game.Id}, game);

});

// PUT: games/1
app.MapPut("games/{id}", (int id, UpdateGameDto updateGame) => 
{ 
    var index = games.FindIndex(game => game.Id == id);

    games[index] = new GameDto(
        id,
        updateGame.Name,
        updateGame.Genre,
        updateGame.Price,
        updateGame.ReleaseDate
        );

    return Results.NoContent();
});

// DELETE: games/2
app.MapDelete("games/{id}", (int id) =>
{
    games.RemoveAll(game => game.Id == id);  

    return Results.NoContent();
});


app.Run();
