using MauiEcommerceDesign.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Collections.ObjectModel;
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
    private ObservableCollection<Review> reviews;
    public ObservableCollection<Review> Reviews
    {
        get => reviews;
        set => SetProperty(ref reviews, value);
    }
    public string Name { get => Product?.Name; }
    public string Description { get => Product?.Description; }
    public decimal Price { get => Product.Price; }
    public decimal OldPrice { get => Product.OldPrice; }
    public bool IsVisibleOldPrice { get => Product.OldPrice != 0 && Product.OldPrice > Product.Price; }
    public ICommand AddToCartCommand { get; internal set; }
    public ICommand NavigateToDetailCommand => new AsyncCommand(NavigateToDetailCommandExecute);
    public ICommand UpdateWishlistCommand => new AsyncCommand(UpdateWishlistCommandExecute);
    public ICommand FetchProductReviewsCommand => new AsyncCommand(FetchProductReviewsExecute);
    public ProductViewModel(Product product)
    {
        Product = product;
        reviews = new ObservableCollection<Review>();
    }

    internal Task InitializeAsync()
    {
        foreach (var pro in Product.Reviews)
            Reviews.Add(pro);
        return Task.CompletedTask;
    }

    private async Task FetchProductReviewsExecute()
    {
        Device.BeginInvokeOnMainThread(() => {
            for (int i = 0; i < 6; i++)
                this.Reviews.Add(new Review
                {
                    Name = i % 2 == 0 ? "Tai Nguyen" : "David John",
                    Avatar = i % 2 == 0 ? "avatar1.png" : "avatar2.png",
                    Comment = i % 2 == 0 ? "Best Product." : "Sample comment data.",
                    Date = $"2022/03/2{i}"
                });
        });
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
