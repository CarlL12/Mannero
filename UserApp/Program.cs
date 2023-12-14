using UserApp.Services;

namespace UserApp;

internal class Program
{
    static void Main(string[] args)
    {
        MenuService menuService = new MenuService();

        menuService.ShowMenu();
    }
}
