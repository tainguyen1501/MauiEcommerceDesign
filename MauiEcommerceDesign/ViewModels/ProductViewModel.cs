using MauiEcommerceDesign.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Windows.Input;

namespace MauiEcommerceDesign.ViewModels;

public class ProductViewModel : BaseViewModel
{
    public Product Product { get; set; }

    private bool isFavorite;

    public bool IsFavorite
    {
        get
        {
            return isFavorite;
        }

        set
        {
            SetProperty(ref isFavorite, value);
        }
    }

    public string[] Images { get => Product?.Images; }
    public string[] Sizes { get => Product?.Sizes; }
    public string[] Colors { get => Product?.Colors; }
    public string Name { get => Product?.Name; }
    public string Description { get => Product?.Description; }
    public decimal Price { get => Product.Price; }
    public decimal OldPrice { get => Product.OldPrice; }
    public bool IsVisibleOldPrice { get => Product.OldPrice != 0 && Product.OldPrice > Product.Price; }
    public ICommand AddToCartCommand { get; internal set; }
    public ICommand NavigateToDetailCommand => new AsyncCommand(NavigateToDetailCommandExecute);
    public ICommand UpdateWishlistCommand => new AsyncCommand(UpdateWishlistCommandExecute);

    public ProductViewModel(Product product)
    {
        Product = product;
    }

    internal Task InitializeAsync()
    {
        return Task.CompletedTask;
    }

    private Task NavigateToDetailCommandExecute()
    {
        return Shell.Current.GoToAsync($"{nameof(ProductDetailsPage)}?Id={Product.Id}");
    }

    private Task UpdateWishlistCommandExecute()
    {
        this.IsFavorite = !this.IsFavorite;
        return Task.CompletedTask;
    }
}
