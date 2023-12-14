
using System.Windows;

using WpfProject.ViewModels;

namespace WpfProject
{

    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}