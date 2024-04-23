namespace IdeaAppCore.Models
{
    // Idea 객체를 데이터베이스에 추가하고 조회하는 메서드를 선언
    public interface IIdeaRepository 
    {
        Task<Idea> AddIdea(Idea idea);      // Idea 객체를 데이터베이스에 추가, 매개변수(Idea 객체)를 비동기적으로 처리해 Task<Iead>형태로 반환, Task<Iead>== 새로 추가된 Iead 객체
        Task<List<Idea>> GetIdeas();          // 데이터베이스에서 Idea 객체를 조회, 매개변수X, Task<List<Idea>>형태로 반환 == Idea 객체들의 목록
    }
}
