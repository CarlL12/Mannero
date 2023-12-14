
using UserApp.Models;
namespace UserApp.Services;

public class MenuService
{   
    
    UserService userService = new();

    public void ShowMenu ()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("### MENU ###");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Remove user");
            Console.WriteLine("3. Get users");

            int option = int.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    User newUser = new User();
                    Console.Clear();
                    Console.Write("Username:");
                    newUser.UserName = Console.ReadLine()!;
                    Console.Write("Email:");
                    newUser.Email = Console.ReadLine()!;
                    Console.Write("Password:");
                    newUser.Password = Console.ReadLine()!;

                    userService.AddUserToList(newUser);
                    Console.Clear();
                    Console.WriteLine($"Added {newUser.UserName} to the list");
                    Console.Write("Press any key to return to main menu:");
                    Console.ReadKey();
                    break;
                case 3:
                    userService.GetUsersFromList();
                    Console.Write("Press any key to return to main menu:");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
