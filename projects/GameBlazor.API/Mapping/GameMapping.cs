using GameBlazor.API.DTO;
using GameBlazor.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameBlazor.API.Mapping
{
    public static class GameMapping
    {
        /** 게임만들기*/
        public static Game ToEntity(this CreateGameDto game) 
        {
            return new Game()
            {
                Name = game.Name,
                GenreId = game.GenreId,
                Price = game.Price,
                ReleaseDate = game.ReleaseDate,
            };
        }

        /** 게임 수정하기*/
        public static Game ToEntity(this UpdateGameDto game, int id)
        {
            return new Game()
            {
                Id = id,
                Name = game.Name,
                GenreId = game.GenreId,
                Price = game.Price,
                ReleaseDate = game.ReleaseDate,
            };
        }

        public static GameSummaryDto ToGameSummaryDto(this Game game) {
            return new (
                       game.Id,
                       game.Name,
                       game.Genre!.Name,
                       game.Price,
                       game.ReleaseDate
                   );
        }

        public static GameDetailsDto ToGameDetailsDto(this Game game)
        {
            return new(
                       game.Id,
                       game.Name,
                       game.GenreId,
                       game.Price,
                       game.ReleaseDate
                   );
        }
    }
}
