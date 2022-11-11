using MauiEcommerceDesign.Models;
using MvvmHelpers;

namespace MauiEcommerceDesign.ViewModels
{
    public class CartItemViewModel : BaseViewModel
    {
        public CartItem CartItem{ get; set; }

        private bool isFavorite;

        public bool IsFavorite
        {
            get
            {
                return isFavorite;
            }

            set
            {
                SetProperty(ref isFavorite, value);
            }
        }

        public string[] Images { get => CartItem?.Images; }
        public string[] Sizes { get => CartItem?.Sizes; }
        public string[] Colors { get => CartItem?.Colors; }
        public string Name { get => CartItem?.Name; }
        public string Description { get => CartItem?.Description; }
        public decimal Price { get => CartItem.Price; }
        public decimal OldPrice { get => CartItem.OldPrice; }
        public int Quantity { get => CartItem.Quantity; }
        public bool IsVisibleOldPrice { get => CartItem.OldPrice != 0 && CartItem.OldPrice > CartItem.Price; }
        public CartItemViewModel(CartItem cartItem)
        {
            CartItem = cartItem;
        }

        internal Task InitializeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
