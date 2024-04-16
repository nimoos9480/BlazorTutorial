using GameBlazor.Components.Pages;
using GameBlazor.Models;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace GameBlazor.Clients
{
	public class GamesClient
	{
				// readonly = 수정되지 않도록 보호
		private readonly List<GameSummary> games = 
	[
		new()
		{
			Id = 1,
			Name = "Street Fighter II",
			Genre = "Fighting",
			Price = 19.99M,    //  'M'은 decimal 형식의 숫자임을 나타냄
			ReleaseDate = new DateOnly(1992, 7, 15)
		},
				new()
		{
			Id = 2,
			Name = "Final Fantasy XIV",
			Genre = "Roleplaying",
			Price = 59.99M,
			ReleaseDate = new DateOnly(2010, 9, 30)
		},
			new()
		{
			Id = 3,
			Name = "FIFA 23",
			Genre = "Sports",
			Price = 69.66M,
			ReleaseDate = new DateOnly(2022, 9, 27)
		}

	];

		private readonly Genre[] genres = new GenresClient().GetGenres();
		public GameSummary[] GetGames() => [.. games];
		// == games.ToArray()

		public void AddGame(GameDetails game) 
		{
			ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);
			var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));

			var gameSummary = new GameSummary
			{
				Id =games.Count + 1,
				Name = game.Name,
				Genre = genre.Name,
				Price = game.Price,	
				ReleaseDate = game.ReleaseDate
			};

			games.Add(gameSummary);
		}

		public GameDetails GetGame(int id)
		{
			GameSummary? game = games.Find(game => game.Id == id);
			ArgumentNullException.ThrowIfNull(game);

			var genre = genres.Single(genre => string.Equals(
					genre.Name,
					game.Genre,
					StringComparison.OrdinalIgnoreCase));

			return new GameDetails
			{
				Id = game.Id,
				Name = game.Name,
				GenreId = genre.Id.ToString(),
				Price = game.Price,
				ReleaseDate = game.ReleaseDate
			};
		}
	}
}
