﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameBlazor.Converters;
using StringConverter = GameBlazor.Converters.StringConverter;

namespace GameBlazor.Models
{
	public class GameDetails
	{
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public required string Name { get; set; }

		[Required(ErrorMessage = "장르를 선택하세요.")]
		[JsonConverter(typeof(StringConverter))]
		public string? GenreId { get; set; }

		[Range(1, 100)]
		public decimal Price { get; set; }

		public DateOnly ReleaseDate { get; set; }

	}
}




