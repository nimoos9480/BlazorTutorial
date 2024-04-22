using System.ComponentModel.DataAnnotations;

	namespace GameBlazor.Models
{
	public class GameDetails
	{
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public required string Name { get; set; }

		[Required(ErrorMessage = "장르를 선택하세요.")]
		public string? GenreId { get; set; }

		[Range(1, 100)]
		public decimal Price { get; set; }

		public DateOnly ReleaseDate { get; set; }

	}
}




