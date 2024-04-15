namespace BlazorWebAppDemo2 
{
	/* 종속성 주입 */
	public class ContactService 
	{
		public List<Contact> contactList = new List<Contact>();

		public void AddContact(Contact contact) 
		{ 
			contactList.Add(contact);
		} 
	}
}

