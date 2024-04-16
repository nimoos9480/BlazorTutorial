using System.ComponentModel.DataAnnotations;

namespace GameBlazor.Models
{
	public class GameDetails
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "게임명을 입력하세요.")]
		[StringLength(50)]
		public required string Name { get; set; }
		[Required(ErrorMessage = "장르를 선택하세요.")]
		public string? GenreId { get; set; }
		[Range(1, 100, ErrorMessage = "가격은 1부터 100 사이의 값이어야 합니다.")]
		public decimal Price { get; set; }	
		public DateOnly ReleaseDate { get; set; }

	}
}
