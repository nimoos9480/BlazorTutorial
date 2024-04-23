using IdeaAppCore.Data;
using Microsoft.EntityFrameworkCore;

namespace IdeaAppCore.Models
{
    public class IdeaRepository : IIdeaRepository
    {
        private readonly ApplicationDbContext _context;     //  생성자의 매개변수 주입방법으로 context 객체 하나 만들기

        // ctor+tab하면 자동생성
        public IdeaRepository(ApplicationDbContext context)   
        {
            this._context = context;         // IdeaRepository 클래스의 생성자가 ApplicationDbContext 타입의 객체를 매개변수로 받는 것은 의존성 주입을 사용하는 것
        }


        // 입력메서드
        public async Task<Idea> AddIdea(Idea idea)     
        {
            _context.Ideas.Add(idea);
           await  _context.SaveChangesAsync();
            return idea;
        }

        // 출력메서드
        public async Task<List<Idea>> GetIdeas()
        {
            return await _context.Ideas.ToListAsync();
        }
    }
}
