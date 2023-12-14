
using System.Collections.ObjectModel;
using System.Windows;
using TodoApp.ViewModels;

namespace TodoApp;



public partial class MainWindow : Window
{
    
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }


}