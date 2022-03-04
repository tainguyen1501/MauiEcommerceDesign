using MauiEcommerceDesign.ViewModels;

namespace MauiEcommerceDesign;

public partial class TabsPage
{
	public TabsPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}