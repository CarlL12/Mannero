

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace WpfProject.ViewModels;

public partial class MainMenuViewModel : ObservableObject
{
    private readonly IServiceProvider _sp;

    public MainMenuViewModel(IServiceProvider sp)
    {
        _sp = sp;
    }

    [RelayCommand]
    private void NavigateToList()
    {
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<ProductListViewModel>();
    }

    [RelayCommand]
    private void NavigateToAdd()
    {
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<ProductAddViewModel>();
    }


}
