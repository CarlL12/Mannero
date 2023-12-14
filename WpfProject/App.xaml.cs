
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WpfProject.Models;
using WpfProject.Services;
using WpfProject.ViewModels;
using WpfProject.Views;

namespace WpfProject;


public partial class App : Application
{

    private IHost? _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<ProductService>();
                services.AddSingleton<MainWindow>();
                services.AddSingleton<MainViewModel>();
                services.AddTransient<MainMenuView>();
                services.AddTransient<MainMenuViewModel>();
                services.AddTransient<ProductListViewModel>();
                services.AddTransient<ProductListView>();
                services.AddTransient<ProductAddViewModel>();
                services.AddTransient<ProductAddView>();
                services.AddTransient<UpdateProductView>();
                services.AddTransient<UpdateProductViewModel>();


            })
           .Build();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        _host!.Start();

        var mainWindow = _host!.Services.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }
}
