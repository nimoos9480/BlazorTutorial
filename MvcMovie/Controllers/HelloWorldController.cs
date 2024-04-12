using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{

    // GET: /HelloWorld/  
    /*    public string Index()
        {
            return "This is my default action...";  //  컨트롤러 클래스에서 메시지와 함께 문자열을 반환
        }*/

    public IActionResult Index()
    {
         return View();         // 컨트롤러의 View 메서드를 호출    
                                        // 뷰 템플릿을 사용하여 HTML 응답을 생성함
    }

    /* 1번
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }*/

    /* 2번
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web
    public string Welcome(string name, int numTimes = 1) // numTimes 매개 변수에 대해 전달된 값이 없는 경우 해당 매개 변수의 기본값이 1임
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // HtmlEncoder.Default.Encode를 사용하여 JavaScript 사용과 같은 악의적인 입력으로부터 앱을 보호
    }*/

    /* 3번
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        // https://localhost:{PORT}/HelloWorld/Welcome/3?name=Rick URL을 입력
        // 3번째 URL 세그먼트는 경로 매개 변수 id와 일치
    }
    */

    public IActionResult Welcome(string name, int numTimes = 1)
    {

        // 뷰 템플릿에 필요한 동적 데이터(매개 변수)를 ViewData 사전에 넣어줌 (ViewData 사전은 동적 개체로, 모든 형식을 사용 가능)
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }



    /* 기본 URL 라우팅 논리 =>  /[Controller]/[ActionName]/[Parameters]
   

         라우팅 형식이 Program.cs파일에 설정됨
                  app.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");

        앱으로 이동 시 URL 세그먼트를 제공하지 않으면 "Home" 컨트롤러 및 "Home" 메서드가 기본값으로 사용됨
            * [Controller] : 실행할 컨트롤러 클래스를 결정
            * [ActionName] : 클래스의 작업 메서드를 결정, Index는 메서드 이름이 명시적으로 지정되지 않은 경우 컨트롤러에서 호출되는 기본 메서드
            * [Parameters] : 경로 데이터, id 매개변수는 선택 사항 

    */
}