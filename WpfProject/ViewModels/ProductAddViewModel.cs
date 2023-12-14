

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using WpfProject.Models;
using WpfProject.Services;

namespace WpfProject.ViewModels;

public partial class ProductAddViewModel : ObservableObject
{
    private readonly IServiceProvider _sp;
    private readonly ProductService _productService;

    [ObservableProperty]
    private Product productForm = new();

    [ObservableProperty]

    private ObservableCollection<Product> _productList = [];


    public ProductAddViewModel(IServiceProvider sp, ProductService productService)
    {
        _sp = sp;
        _productService = productService;
        UpdateProductList();

    }



    [RelayCommand]
    private void NavigateToMainMenu()
    {
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<MainMenuViewModel>();
    }

    [RelayCommand]

    private void AddProductTolist()
    {
        
        if(ProductForm.Title != null)
        {
            _productService.Add(ProductForm);
            ProductForm = new();


        }

        
    }
    public void UpdateProductList()
    {
        ProductList = new ObservableCollection<Product>(_productService.Products.Select(product => new Product()).ToList());
    }
}
