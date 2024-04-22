using GameBlazor.API.DTO;
using GameBlazor.API.Entities;

namespace GameBlazor.API.Mapping
{
    public static class GenreMapping
    {
        public static GenreDto ToDto(this Genre genre) 
        {
            return new GenreDto(genre.Id, genre.Name);
        }
    }
}
