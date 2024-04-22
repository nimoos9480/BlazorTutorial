using GameBlazor.Components.Pages;
using GameBlazor.Models;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace GameBlazor.Clients
{
	public class GamesClient (HttpClient httpClient)
	{
		// readonly = 수정되지 않도록 보호
		/*private readonly List<GameSummary> games = 
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

	];*/

		/*private readonly Genre[] genres = new GenresClient(httpClient).GetGenres();*/

		public async Task<GameSummary[]> GetGamesAsync()
		     => await   httpClient.GetFromJsonAsync<GameSummary[]>("games") ?? [];
																																	// ?? []는 null 병합 연산자로, 만약 GetFromJsonAsync 메서드가 null을 반환하면 빈 배열을 반환
		//  [.. games]; == games.ToArray()

		/*
		 * public void AddGame(GameDetails game)
		{
			Genre genre = GetGenreById(game.GenreId);

			var gameSummary = new GameSummary
			{
				Id = games.Count + 1,
				Name = game.Name,
				Genre = genre.Name, 
				Price = game.Price,
				ReleaseDate = game.ReleaseDate
			};

			games.Add(gameSummary);
		}*/

			public async Task AddGameAsync(GameDetails game)
					=> await httpClient.PostAsJsonAsync("games", game);


		/*
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

		public void DeleteGame(int id) 
		{
			var game = GetGameSummaryById(id);
			games.Remove(game);
		}
		}*/

		public async Task<GameDetails> GetGameAsync(int id)
			=> await httpClient.GetFromJsonAsync<GameDetails>($"games/{id}")
																										?? throw new Exception("게임을 찾을 수 없습니다!");


/*		public void UpdateGame(GameDetails updateGame) 
		{ 
			var genre = GetGenreById(updateGame.GenreId);
			GameSummary existingGame = GetGameSummaryById(updateGame.Id);

			existingGame.Name = updateGame.Name;
			existingGame.Genre = genre.Name;
			existingGame.Price = existingGame.Price;
			existingGame.ReleaseDate = updateGame.ReleaseDate;	
		}*/

		public async Task UpdateGameAsync(GameDetails updatedGame)
			=> await httpClient.PutAsJsonAsync($"games/{updatedGame.Id}", updatedGame);

/*		public void DeleteGame(int id)
		{
			var game = GetGameSummaryById(id);
			GamesClient.Remove(game);
		}*/

		public async Task DeleteGameAsync(int id)
			=> await httpClient.DeleteAsync($"games/{id}");

/*		private GameSummary GetGameSummaryById(int id)
		{ 
			GameSummary? game = games.Find(game => game.Id == id);
			ArgumentNullException.ThrowIfNull(game);
			return game;
		}
	
		private Genre GetGenreById(string? id)
		{
			ArgumentException.ThrowIfNullOrWhiteSpace(id);
			return genres.Single(genre => genre.Id == int.Parse(id));
		}
		*/

	}
}
