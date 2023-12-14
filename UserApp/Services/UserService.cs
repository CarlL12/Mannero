

using UserApp.Models;

namespace UserApp.Services;

public class UserService
{

    private readonly List<User> _users = [];


    public void AddUserToList (User user)
    {
        if (!_users.Any(x => x.Email == user.Email))
        {
            
            _users.Add(user);
        }
        else
        {
            Console.WriteLine("User already exists!");
        }
    }

    public void GetUsersFromList() 
    {
        foreach (User u in _users)
        {
            Console.WriteLine("_____");
            Console.WriteLine($"Username: {u.UserName}");
            Console.WriteLine($"Email: {u.Email}");
            Console.WriteLine($"Password: {u.Password}");
        }

    }
}
