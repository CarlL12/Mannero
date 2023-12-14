
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TodoApp.Model;

namespace TodoApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private Contact contactForm = new();

    [ObservableProperty]

    private ObservableCollection<Contact> contactList = [];


    [RelayCommand]

    public void AddContactToList()
    {
        if (!string.IsNullOrWhiteSpace(ContactForm.FirstName) && ContactForm.LastName != null)
        {
            ContactList.Add(ContactForm);
            ContactForm = new();
        }
    }

    [RelayCommand]

    public void RemoveContactFromList(Contact contact)
    {
        if (contact != null)
        {
            ContactList.Remove(contact);
        }
    }
}
