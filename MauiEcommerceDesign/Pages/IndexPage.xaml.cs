using MauiEcommerceDesign.ViewModels;

namespace MauiEcommerceDesign;

public partial class IndexPage : ContentPage
{
	IndexViewModel viewModel => BindingContext as IndexViewModel;
	public IndexPage(IndexViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();
		viewModel.InitializeAsync();

        StackLayout stackLayout = new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
        };

        foreach (var category in viewModel.Categories)
        {
            stackLayout.Children.Add
               (
                   new Button
                   {
                       Text = category.Name,
                       TextColor = Color.Parse("White"),
                       FontSize = 15,
                       BackgroundColor = Color.Parse("Black"),
                       Margin= new Thickness(0,0,10,0),
                   }
               );
        }

        //Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);
        this.CategoriesListContent.Children.Add(new ScrollView
        {
            Orientation = ScrollOrientation.Horizontal,
            HorizontalScrollBarVisibility = ScrollBarVisibility.Never,
            Content = stackLayout
        });
    }

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
        this.CategoriesListContent.Children.Clear();
    }
}