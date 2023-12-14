using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using WpfProject.Models;
using WpfProject.Services;

namespace WpfProject.ViewModels;

public partial class ProductListViewModel : ObservableObject
{

    private readonly IServiceProvider _sp;
    private readonly ProductService _productService;
    private readonly UpdateProductViewModel _updateProductViewModel;

    public ProductListViewModel(IServiceProvider sp, ProductService productService, UpdateProductViewModel updateProductViewModel)
    {
        _sp = sp;
        _productService = productService;
        _updateProductViewModel = updateProductViewModel;
        UpdateProductList();
    }

    [ObservableProperty]

    private ObservableCollection<Product> _productList = [];

    [ObservableProperty]

    private Product product = new Product();




    [RelayCommand]
    private void NavigateToMainMenu()
    {
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<MainMenuViewModel>();
    }

    [RelayCommand]
    private void NavigateToUpdateProduct(Product product) 
    {
        _updateProductViewModel.SelectedProduct = product;
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _updateProductViewModel;

    }

    [RelayCommand]
    public void RemoveProductFromList(Product product)
    {
        if (product != null)
        {
            _productService.Remove(product);
            UpdateProductList();
            
        }
    }
    public void UpdateProductList()
    {
        ProductList = new ObservableCollection<Product>(_productService.Products);
    }


}
