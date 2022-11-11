using MauiEcommerceDesign.ViewModels;

namespace MauiEcommerceDesign;

public partial class CartPage : ContentPage
{
    CartViewModel viewModel => BindingContext as CartViewModel;
    public CartPage(CartViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.Initialize();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}