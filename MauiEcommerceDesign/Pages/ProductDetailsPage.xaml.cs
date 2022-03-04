using MauiEcommerceDesign.ViewModels;

namespace MauiEcommerceDesign;

public partial class ProductDetailsPage : ContentPage
{
	private ProductDetailsViewModel viewModel => BindingContext as ProductDetailsViewModel;
	public ProductDetailsPage(ProductDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await viewModel.InitializeAsync();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}