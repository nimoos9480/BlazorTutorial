﻿using System.ComponentModel.DataAnnotations;

namespace GameBlazor.API.DTO
{
    public record class CreateGameDto
    (
        [Required][StringLength(50)] string Name,
/*     [Required][StringLength(20)] string Genre, */
        int GenreId,
        [Range(1,100)] decimal Price,
        DateOnly ReleaseDate
    );
}
