namespace GameBlazor.API.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        //    * 관계형 모델을 사용해 Game을 Genre와 연결해야 함 
        public int GenreId { get; set; }             // 1. 속성 정의  - Game에 연관될 GenreId의 속성을 정의
        public Genre? Genre { get; set; }        // 2. Foreign Key (Genre 속성은 실제 Genre 객체에 대한 참조)


        public decimal Price { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}
