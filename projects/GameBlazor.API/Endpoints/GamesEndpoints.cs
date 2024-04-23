using GameBlazor.API.Data;
using GameBlazor.API.DTO;
using GameBlazor.API.Entities;
using GameBlazor.API.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameBlazor.API.Endpoints
{
    public static class GamesEndpoints
    {

        const string GetGameEndpointName = "GetName";

        //private static readonly List<GameSummaryDto> games = [
        //    new(
        //            1,
        //            "Street Fighter II",
        //            "Fighting",
        //            19.99M,
        //            new DateOnly(1992, 7, 15)
        //        ),
        //        new(
        //            2,
        //            "Final Fantasy XIV",
        //            "Roleplaying",
        //            59.99M,
        //            new DateOnly(2010, 9, 30)
        //        ),
        //        new(
        //            3,
        //            "FIFA 23",
        //            "Sports",
        //            69.99M,
        //            new DateOnly(2022, 9, 27)
        //           ),
        //];

        public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
        {

            var group = app.MapGroup("games")
                                        .WithParameterValidation();  // 누겟패키지 사용


            // GET: /games
            group.MapGet("/", async (GameStoreContext dbContext) => {
                /*await Task.Delay(3000);  // 3초 딜레이*/

                await dbContext.Games
                                        .Include(game => game.Genre)                                    // 게임의 장르 정보 로드
                                        .Select(game => game.ToGameSummaryDto())          // 게임 요약 데이터 DTO로 매핑
                                        .AsNoTracking()                                                             // 쿼리 결과 추적은 비활성화(읽기전용 쿼리, 데이터 변경 안할때)
                                        .ToListAsync();
            });                                                           


            // GET: games/1
            group.MapGet("/{id}", async (int id, GameStoreContext dbContext) =>
            {
                /*GameDto? game = games.Find(game => game.Id == id);*/
                Game? game = await dbContext.Games.FindAsync(id);

                return game is null ? 
                                      Results.NotFound() : Results.Ok(game.ToGameDetailsDto());
            })
             .WithName(GetGameEndpointName);  // 엔드포인트에 이름("GetName")을 부여 ==> 해당 엔드포인트에 대한 URL을 생성하거나 참조하는데 사용 가능

            //POST: games
            group.MapPost("/", async (CreateGameDto newGame, GameStoreContext dbContext) =>
            {

                /** GameStoreContext dbContext 의존성 주입으로 생략*/
                //GameDto game = new(
                //    games.Count + 1,
                //    newGame.Name,
                //    newGame.Genre,
                //    newGame.Price,
                //    newGame.ReleaseDate
                // );

                /** Mapping으로 인한 생략*/
                //Game game = new()
                //{
                //    Name = newGame.Name,
                //    Genre = dbContext.Genres.Find(newGame.GenreId), // 사용자들은 GenreId를 보내올 것 ==> 기존 String 형식이던 DTO int형식으로 수정
                //    GenreId = newGame.GenreId,
                //    Price = newGame.Price,
                //    ReleaseDate = newGame.ReleaseDate,
                //};

                Game game = newGame.ToEntity();
                /*game.Genre = dbContext.Genres.Find(newGame.GenreId); ==> 엔터티 프레임워크카 id 할당, 더 이상 필요 없음*/

                 // games.Add(game);
                 dbContext.Games.Add(game);
                await dbContext.SaveChangesAsync(); // 컨텍스트 변경사항을 바로 저장

                /** Mapping으로 인한 생략*/
                //GameDto gameDto = new(
                //        game.Id,
                //        game.Name,
                //        game.Genre!.Name,
                //        game.Price,
                //        game.ReleaseDate
                //    );

                return Results.CreatedAtRoute(
                                            GetGameEndpointName, 
                                            new { id = game.Id }, 
                                            game.ToGameDetailsDto());
                            });
                

            // PUT: games/1
            group.MapPut("/{id}", async (int id, UpdateGameDto updateGame, GameStoreContext dbContext) =>
            {
                /*var index = games.FindIndex(game => game.Id == id);*/
                var existingGame = await dbContext.Games.FindAsync(id);

                // if( index == -1)
                if (existingGame is null)
                {
                    return Results.NotFound();
                }
                //games[index] = new GameSummaryDto(
                //    id,
                //    updateGame.Name,
                //    updateGame.Genre,
                //    updateGame.Price,
                //    updateGame.ReleaseDate
                //);

                dbContext.Entry(existingGame)
                                            .CurrentValues
                                            .SetValues(updateGame.ToEntity(id));

                await dbContext.SaveChangesAsync();

                return Results.NoContent();

            });

            // DELETE: games/2
            group.MapDelete("/{id}", async (int id, GameStoreContext dbcontext) =>
            {
                /*games.RemoveAll(game => game.Id == id);*/
                await dbcontext.Games
                                 .Where(game => game.Id == id)
                                 .ExecuteDeleteAsync();           // 일괄 삭제    

                return Results.NoContent();
            });

            return group;

        }

    }
}
