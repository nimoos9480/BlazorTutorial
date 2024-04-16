using BlazorWebAppDemo.Components.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAppDemo.Components.Pages
{

	
	/* Home.razor의 C#코드인 @Code부분 옮긴 것*/
	/* 코드를 다른 cs파일에 추가하려면 부분 클래스로 만들어야 한다*/
	public partial class Home
	{

		/* 의존성 주입을 사용하는 방법 */
		[Inject]
		IContactService contactService { get; set; }

		private List<Contact> contacts;
		private Dictionary<string, object> MyTextboxAttributes = new Dictionary<string, object>
	{
		{ "placeholder" , "FirstName"},
		{ "disabled", "disabled"}
	};


		protected async override Task OnInitializedAsync()
		{
			await Task.Delay(5000); // 데이터베이스에서 데이터를 충분히 가져올 수 있도록 일정시간동안 지연

			//	contacts = contactService.GetContacts(); // demo01페이지에서 삽입한 데이터 Home화면에서 확인 가능
			contacts = new List<Contact>
		{
			new Contact
			{
				FirstName = "John",
				LastName = "Thmas",
				Email = "john@gmail.com"
			},
			new Contact
			{
				FirstName = "Peter",
				LastName = "Bob",
				Email = "peter@gmail.com"
			},
			new Contact
			{
				FirstName = "George",
				LastName = "David",
				Email = "george@gmail.com"
			}
		};
			base.OnInitializedAsync();
		}


	}
}
