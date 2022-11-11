using MauiEcommerceDesign.ViewModels;
using System.Windows.Input;

namespace MauiEcommerceDesign.Views;

public partial class CartItemView
{
    public static readonly BindableProperty SubscriptionCommandProperty =
        BindableProperty.Create(
            nameof(SubscriptionCommand),
            typeof(ICommand),
            typeof(CartItemView),
            default(string));

    public static readonly BindableProperty SubscriptionCommandParameterProperty =
        BindableProperty.Create(
            nameof(SubscriptionCommandParameter),
            typeof(CartItemViewModel),
            typeof(CartItemView),
            default(CartItemViewModel));

    public ICommand SubscriptionCommand
    {
        get { return (ICommand)GetValue(SubscriptionCommandProperty); }
        set { SetValue(SubscriptionCommandProperty, value); }
    }

    public CartItemViewModel SubscriptionCommandParameter
    {
        get { return (CartItemViewModel)GetValue(SubscriptionCommandParameterProperty); }
        set { SetValue(SubscriptionCommandParameterProperty, value); }
    }
    public CartItemView()
    {
        InitializeComponent();
    }
}