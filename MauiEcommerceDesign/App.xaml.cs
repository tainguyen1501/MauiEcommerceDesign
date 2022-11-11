namespace MauiEcommerceDesign;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new TabsPage();

		Routing.RegisterRoute(nameof(IndexPage), typeof(IndexPage));
		Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
		Routing.RegisterRoute(nameof(ProductDetailsPage), typeof(ProductDetailsPage));

		Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
	}
}