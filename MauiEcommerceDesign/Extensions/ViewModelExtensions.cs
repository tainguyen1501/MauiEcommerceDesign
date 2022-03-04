using MauiEcommerceDesign.ViewModels;

namespace MauiEcommerceDesign.Extensions;

public static class ViewModelExtensions
{
    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<IndexViewModel>();
        builder.Services.AddSingleton<ProductDetailsViewModel>();
        return builder;
    }
}
