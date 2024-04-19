namespace GameBlazor.API.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public required string Name { get; set; }  //  null 불가
    }
}
