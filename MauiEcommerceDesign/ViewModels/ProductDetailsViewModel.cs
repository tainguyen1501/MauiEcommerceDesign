using MauiEcommerceDesign.Models;
using MauiEcommerceDesign.SeedWork;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

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

        //private ObservableCollection<Review> reviews;
        //public ObservableCollection<Review> Reviews2
        //{
        //    get => reviews;
        //    set => SetProperty(ref reviews, value);
        //}
        //public ProductDetailsViewModel()
        //{
        //    reviews = new ObservableCollection<Review>();
        //}

        internal async Task InitializeAsync()
        {
            await FetchProductAsync();
            await Product.InitializeAsync();
            //for (int i = 0; i < 6; i++)
            //    Reviews2.Add(new Review
            //    {
            //        Name = i % 2 == 0 ? "Tai Nguyen" : "David John",
            //        Avatar = i % 2 == 0 ? "avatar1.png" : "avatar2.png",
            //        Comment = i % 2 == 0 ? "Best Product." : "Sample comment data.",
            //        Date = $"2022/03/2{i}"
            //    });
        }
        //public ICommand FetchProductReviews2Command => new AsyncCommand(FetchProductReviews2Execute);
        //private async Task FetchProductReviews2Execute()
        //{
        //    Product.FetchProductReviewsCommand();
        //    await Task.Run(() =>
        //    {
        //        if (product.Reviews == null)
        //            product.Reviews = new List<Review>();
        //        for (int i = 0; i < 6; i++)
        //            Product.Reviews.Add(new Review
        //            {
        //                Name = i % 2 == 0 ? "Tai Nguyen" : "David John",
        //                Avatar = i % 2 == 0 ? "avatar1.png" : "avatar2.png",
        //                Comment = i % 2 == 0 ? "Best Product." : "Sample comment data.",
        //                Date = $"2022/03/2{i}"
        //            });
        //    });
        //}
        private async Task FetchProductAsync()
        {

            await Task.Run(() =>
            {
                var product = Data.Products.FirstOrDefault(x => x.Id == Guid.Parse(Id));
                product.Reviews = new List<Review>();
                List<Review> reviews = new();
                for (int i = 0; i < 6; i++)
                    product.Reviews.Add(new Review
                    {
                        Name = i % 2 == 0 ? "Tai Nguyen" : "David John",
                        Avatar = i % 2 == 0 ? "avatar1.png" : "avatar2.png",
                        Comment = i % 2 == 0 ? "Best Product." : "Sample comment data.",
                        Date = $"2022/03/2{i}"
                    });
                Product = new ProductViewModel(product);
            });
        }
    }
}
