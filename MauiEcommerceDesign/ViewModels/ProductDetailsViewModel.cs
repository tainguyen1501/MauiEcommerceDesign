using MauiEcommerceDesign.SeedWork;
using MvvmHelpers;

namespace MauiEcommerceDesign.ViewModels
{
    [QueryProperty(nameof(Id), nameof(Id))]
    public class ProductDetailsViewModel: BaseViewModel
    {
        public string Id { get; set; }


        private ProductViewModel product;
        public ProductViewModel Product
        {
            get => product;
            set => SetProperty(ref product, value);
        }

        internal async Task InitializeAsync()
        {
            await FetchProductAsync();
        }
        private async Task FetchProductAsync()
        {
            await Task.Run(() =>
            {
                var product = Data.Products.FirstOrDefault(x => x.Id == Guid.Parse(Id));
                Product = new ProductViewModel(product);
            });
        }
    }
}
