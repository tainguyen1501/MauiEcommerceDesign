using MauiEcommerceDesign.SeedWork;
using MvvmHelpers;
using System.Collections.ObjectModel;

namespace MauiEcommerceDesign.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        private ObservableCollection<CartItemViewModel> items;
        public ObservableCollection<CartItemViewModel> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                this.SetProperty(ref this.items, value);
            }
        }
        public CartViewModel()
        {
            items = new ObservableCollection<CartItemViewModel>();
        }

        public void Initialize()
        {
            items.Clear();
            foreach (var i in Data.CartItems)
                items.Add(new CartItemViewModel(i));
        }
    }
}
