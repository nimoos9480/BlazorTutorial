using BlazorWebAppDemo.Components.Models;

namespace BlazorWebAppDemo
{
    public class ContactService : IContactService
    {
        private List<Contact> ContactList = new List<Contact>();

        public List<Contact> GetContacts() { return ContactList; }

        public void AddContact(Contact contact) 
        {
            ContactList.Add(contact);  
        }
    }
}
