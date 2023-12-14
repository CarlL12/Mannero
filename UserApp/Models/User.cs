
namespace UserApp.Models;

public class User
{
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Email { get; set; } = null!;

    public User (string userName, string password, string email)
    {
        UserName = userName;
        Password = password;
        Email = email;

    }

    public User()
    {

    }
}
