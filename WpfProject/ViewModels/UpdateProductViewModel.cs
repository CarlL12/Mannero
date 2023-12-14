using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using WpfProject.Models;
using WpfProject.Services;


namespace WpfProject.ViewModels;

public partial class UpdateProductViewModel : ObservableObject
{
    private readonly IServiceProvider _sp;
    private readonly ProductService _productService;

    [ObservableProperty]
    private Product _selectedProduct = null!;


    public UpdateProductViewModel(IServiceProvider sp, ProductService productService)
    {
        _sp = sp;
        _productService = productService;

    }




    [RelayCommand]
    private void NavigateToList()
    {
        Product UpdatedProduct = _productService.Update(SelectedProduct);
        _productService.Add(UpdatedProduct);
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<ProductListViewModel>();
    }
}
