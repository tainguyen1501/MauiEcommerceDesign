using MauiEcommerceDesign.Models;

namespace MauiEcommerceDesign.SeedWork
{
    public static class Data
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = Guid.Parse("1ed5b8d5-cc56-425a-95a7-a58af63212fd"),
                Name = "Air Jordan 1 Elevate Low SE",
                Description = "Description",
                Price = 1000,
                OldPrice = 1898,
                Images = new string[] { "product1.png", "product2.png", "product3.png", "product4.png", "product5.png", "product6.png"},
                Sizes = new string []{"8.5", "9", "9.5", "10", "10.5", "11", "11.5"},
                Colors = new string[] {"Black", "#f5f8f7", "#286ded", "White", "#f56603"}
            },
            new Product
            {
                Id = Guid.Parse("1ed5b8d5-cc56-425a-95a7-a58af63212fe"),
                Name = "Air Jordan 1 Retro High OG",
                Description = "Description",
                Price = 983,
                OldPrice = 1897,
                Images = new string[] { $"product2.png"},
                Sizes = new string []{"8.5", "9", "9.5", "10", "10.5", "11", "11.5"},
                Colors = new string[] {"Black", "#f5f8f7", "#286ded", "White", "#f56603"}
            },
            new Product
            {
                Id = Guid.Parse("1ed5b8d6-cc56-425a-95a7-a58af63212fe"),
                Name = "Air Jordan 6 Retro",
                Description = "Description",
                Price = 895,
                Images = new string[] { $"product3.png"},
                    Sizes = new string []{"8.5", "9", "9.5", "10", "10.5"},
                Colors = new string[] {"Black", "#f5f8f7", "#286ded", "#f56603"}
            },
            new Product
            {
                Id = Guid.Parse("1ed5b9d1-cc56-425a-95a7-a58af63212fe"),
                Name = "Jordan MH",
                Description = "Description",
                Price = 766,
                OldPrice = 998,
                Images = new string[] { $"product4.png"},
                Sizes = new string []{"8.5", "9", "9.5", "10", "10.5", "11", "11.5"},
                Colors = new string[] {"Black", "#f5f8f7", "#286ded", "White", "#f56603"}
            },
            new Product
            {
                Id = Guid.Parse("1ed5b9d1-cc56-425a-95a7-a58af68952fe"),
                 Name = "Air Jordan 1 Retro High OG",
                Description = "Description",
                Price = 770,
                Images = new string[] { $"product5.png"},
            },
            new Product
            {
                Id = Guid.Parse("1ed5b9d1-cc56-425a-95a7-a58af60942fe"),
                Name = "Jordan MA",
                Description = "Description",
                Price = 900,
                OldPrice = 1298,
                Images = new string[] { $"product6.png"},
            },
            new Product
            {
                Id = Guid.Parse("1ed5b9d1-cc56-425a-95a7-a58af93942fe"),
                Name = "Jordan MA",
                Description = "Description",
                Price = 901,
                Images = new string[] { $"product7.png"},
            },
            new Product
            {
                Id = Guid.Parse("1ed5b9d1-cc56-425a-95a7-a58af66942fe"),
                Name = "Jordan MA",
                Description = "Description",
                Price = 1000,
                OldPrice = 1898,
                Images = new string[] { $"product8.png"},
            },
            new Product
            {
                Id = Guid.Parse("1ed5b9d1-cc56-425a-95a7-a58af97632fe"),
                Name = "Air Jordan 1 Retro High OG",
                Description = "Description",
                Price = 1000,
                OldPrice = 1898,
                Images = new string[] { $"product9.png"},
            },
            new Product
            {
                Id = Guid.Parse("1ed5b9d1-cc56-425a-95a7-a58af77742fe"),
                Name = "Jordan MA",
                Description = "Description",
                Price = 1000,
                OldPrice = 1898,
                Images = new string[] { $"product10.png"},
            }
        };

        public static List<CartItem> CartItems = new List<CartItem>
        {
             new CartItem
             {
                ProductId = Guid.Parse("1ed5b8d5-cc56-425a-95a7-a58af63212fd"),
                Name = "Air Jordan 1 Elevate Low SE",
                Description = "Description",
                Price = 1000,
                OldPrice = 1898,
                Images = new string[] { "product1.png", "product2.png", "product3.png", "product4.png", "product5.png", "product6.png"},
                Sizes = new string []{"8.5", "9", "9.5", "10", "10.5", "11", "11.5"},
                Colors = new string[] {"Black", "#f5f8f7", "#286ded", "White", "#f56603"},
                Quantity = 2
             },
            new CartItem
            {
                ProductId = Guid.Parse("1ed5b8d5-cc56-425a-95a7-a58af63212fe"),
                Name = "Air Jordan 1 Retro High OG",
                Description = "Description",
                Price = 983,
                OldPrice = 1897,
                Images = new string[] { $"product2.png"},
                Sizes = new string []{"8.5", "9", "9.5", "10", "10.5", "11", "11.5"},
                Colors = new string[] {"Black", "#f5f8f7", "#286ded", "White", "#f56603"},
                Quantity = 3
            },
            new CartItem
            {
                ProductId = Guid.Parse("1ed5b8d6-cc56-425a-95a7-a58af63212fe"),
                Name = "Air Jordan 6 Retro",
                Description = "Description",
                Price = 895,
                Images = new string[] { $"product3.png"},
                Sizes = new string []{"8.5", "9", "9.5", "10", "10.5"},
                Colors = new string[] {"Black", "#f5f8f7", "#286ded", "#f56603"},
                Quantity = 1
            },
            new CartItem
            {
                ProductId = Guid.Parse("1ed5b9d1-cc56-425a-95a7-a58af63212fe"),
                Name = "Jordan MH",
                Description = "Description",
                Price = 766,
                OldPrice = 998,
                Images = new string[] { $"product4.png"},
                Sizes = new string []{"8.5", "9", "9.5", "10", "10.5", "11", "11.5"},
                Colors = new string[] {"Black", "#f5f8f7", "#286ded", "White", "#f56603"},
                Quantity = 1
            },
            new CartItem
            {
                ProductId = Guid.Parse("1ed5b9d1-cc56-425a-95a7-a58af68952fe"),
                Name = "Air Jordan 1 Retro High OG",
                Description = "Description",
                Price = 770,
                Images = new string[] { $"product5.png"},
                Quantity = 2
            },
        };
    }
}
