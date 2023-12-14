﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using TodoApp.ViewModels;


namespace TodoApp;


public partial class App : Application
{
    private static IHost? builder;

    public App()
    {
        builder = Host.CreateDefaultBuilder()
           .ConfigureServices(services =>
           {
               services.AddSingleton<MainWindow>();
               services.AddSingleton<MainViewModel>();

           })
           .Build();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        builder!.Start();

        var mainWindow = builder!.Services.GetRequiredService<MainWindow>();

        mainWindow.Show();
    }
}
