using MauiEcommerceDesign.Models;
using MauiEcommerceDesign.SeedWork;
using MvvmHelpers;
using System.Collections.ObjectModel;

namespace MauiEcommerceDesign.ViewModels
{
    public class IndexViewModel : BaseViewModel
    {
        private ObservableCollection<ProductViewModel> products;
        public ObservableCollection<ProductViewModel> Products
        {
            get
            {
                return this.products;
            }
            set
            {
                this.SetProperty(ref this.products, value);
            }
        }

        private ObservableCollection<Category> categories;
        public ObservableCollection<Category> Categories
        {
            get
            {
                return this.categories;
            }
            set
            {
                this.SetProperty(ref this.categories, value);
            }
        }
        public IndexViewModel()
        {
            products = new ObservableCollection<ProductViewModel>();
            categories = new ObservableCollection<Category>();
        }

        public void InitializeAsync()
        {
            products.Clear();
            foreach(var product in Data.Products)
                products.Add(new ProductViewModel(product));

            categories.Clear();
            categories.Add(new Category
            {
                Name = "All"
            });
            categories.Add(new Category
            {
                Name = "Adidas"
            });
            categories.Add(new Category
            {
                Name = "Nike"
            });
            categories.Add(new Category
            {
                Name = "Puma"
            });
            categories.Add(new Category
            {
                Name = "All"
            });
            categories.Add(new Category
            {
                Name = "Adidas"
            });
            categories.Add(new Category
            {
                Name = "Nike"
            });
            categories.Add(new Category
            {
                Name = "Puma"
            });
        }
    }

}

public class Category
{
    public string Name { get; set; }
}
