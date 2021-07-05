using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTest2.Model
{
    public class ProductRepository
    {
        public static Product[] GetAllProducts()
        {
            return new[]
            {
            new Product(1, "Hummingbird printed T-Shirt", "Regular fit, round neckline, short sleeves. Made of extra long staple pima cotton.", "hummingbird-printed-t-shirt.jpg", 22.93m),
            new Product(2, "Today is a good day framed poster", "Printed on rigid paper with matt finish and smooth surface.", "today-is-a-good-day-framed-poster.jpg", 34.00m),
            new Product(3, "Mug the adventure begins", "White Ceramic Mug. 325ml.", "mug-the-adventure-begins.jpg", 14.25m),
            new Product(4, "Brown bear cushion", "Cushion with removable cover and invisible zip on the back. 32x32cm.", "brown-bear-cushion.jpg", 22.65m),
            new Product(5, "Mountain fox notebook", "120 sheets notebook with hard cover made of recycled cardboard. 16x22cm.", "mountain-fox-notebook.jpg", 18.10m),
            };
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }


        public Product(int id, string title, string description, string image, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            Price = price;
        }
    }


}
