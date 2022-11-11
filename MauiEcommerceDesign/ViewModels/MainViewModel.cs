using MauiEcommerceDesign.Resources.Strings;

namespace MauiEcommerceDesign.ViewModels
{
    public class MainViewModel
    {
        public AppSection Home { get; set; }
        public AppSection Wishlist { get; set; }
        public AppSection Lists { get; set; }
        public AppSection ListenLater { get; set; }
        public AppSection Settings { get; set; }
        public AppSection ListenTogether { get; set; }

        public MainViewModel()
        {
            Home = new AppSection() { Title = AppResource.Home, Icon = "discover.png", IconDark = "discover.png", TargetType = typeof(IndexPage) };
            Wishlist = new AppSection() { Title = AppResource.Wishlist, Icon = "wishlist.png", IconDark = "wishlist.png", TargetType = typeof(TestPage) };
            ListenLater = new AppSection() { Title = AppConfig.Desktop ? AppResource.Cart : AppResource.Cart, Icon = "Cart.png", IconDark = "clock_dark.png", TargetType = typeof(CartPage) };
            ListenTogether = new AppSection() { Title = AppConfig.Desktop ? AppResource.Account : AppResource.Account, Icon = "user.png", IconDark = "user.png", TargetType = typeof(MainPage) };
            Settings = new AppSection() { Title = AppResource.Settings, Icon = "settings.png", IconDark = "settings_dark.png", TargetType = typeof(MainPage) };
        }
    }

    public class AppSection
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string IconDark { get; set; }
        public Type TargetType { get; set; }

    }
}
