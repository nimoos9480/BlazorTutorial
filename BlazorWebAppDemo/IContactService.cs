using BlazorWebAppDemo.Components.Models;

namespace BlazorWebAppDemo
{
	public interface IContactService
	{
		List<Contact> GetContacts();

		void AddContact(Contact contact);
	}
}
