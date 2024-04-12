using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MvcMovieContext _context;

        public MoviesController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Movies
       //Index(string searchString) : /Movies/Index? searchString = Ghost
        public async Task<IActionResult> Index(string movieGenre, string searchString)
        {
            if (_context.Movie == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            // 영화장르를 선택하는 LINQ(Language-Integrated Query)
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;
            var movies = from m in _context.Movie
                         select m;      // 쿼리는 정의는 O, 데이터베이스에 대해 실행은 X


            // searchString 매개 변수에 문자열이 담겨 있으면 해당 검색 문자열의 값으로 필터링하도록 영화 쿼리를 수정
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title!.Contains(searchString));
                // Where() : 데이터 컬렉션에서 특정 조건을 만족하는 요소들을 필터링하는 데 사용
                //  s.Title! : Title 속성이 null일 수도 있는 상황에 대비 (null 예외를 방지)
                //                               <-> s.Title?을 사용하면 s 객체가 null이 아닌 경우에만 Title 속성에 접근하고, 그렇지 않은 경우에는 null을 반환
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            var movieGenreVM = new MovieGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Movies = await movies.ToListAsync()
            };
           /* return View(await movies.ToListAsync());*/
            return View(movieGenreVM);


        }

        // GET: Movies
        /*// Index(string id) : /Movies/Index/ghost
        public async Task<IActionResult> Index(string id)
        {
            if (_context.Movie == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var movies = from m in _context.Movie
                         select m;

            if (!String.IsNullOrEmpty(id))
            {
                movies = movies.Where(s => s.Title!.Contains(id));
            }

            return View(await movies.ToListAsync());
        }*/


        [HttpPost]
        public string Index(string searchString, bool notUsed)  // notUsed 매개 변수는 Index 메서드의 오버로드를 만들기 위해서 사용
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }




        // GET: Movies/Details/5    == movies/details?id=1
        public async Task<IActionResult> Details(int? id)   // id값이 제공되지 않는 경우 id매개변수가 nullable 형식으로 정의
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost] // 이 Edit 메서드가 POST 요청에 대해서만 호출될 수 있음을 지정 (GET의 경우  [HttpGet]이 기본값)
        [ValidateAntiForgeryToken] // 요청 위조 방지 
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
        {                                                                           // [Bind] 특성은 과도한 게시를 방지하기 위한 한 가지 방법(변경하려는 속성만 [Bind] 특성에 포함)
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id, bool notUsed)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        /*  HTTP GET Delete 메서드는 지정한 영화를 삭제하지 않고 삭제를 제출(HttpPost)할 수 있는 영화의 보기를 반환한다는 점에 유의
         *      - GET 요청에 대한 응답에서 삭제 작업을 수행하는 것은
         *      (또는 해당 문제에 대한 편집 작업, 만들기 작업 또는 데이터를 변경하는 기타 작업을 수행하는 것은) 보안 허점을 야기*/

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            if (movie != null)
            {
                _context.Movie.Remove(movie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
