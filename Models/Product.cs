using System;

namespace shop.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(Guid id, string title, string tag, double price, string description, string brand, string[] images, Category category)
        {
            Id = id;
            Title = title;
            Tag = tag;
            Price = price;
            Description = description;
            Brand = brand;
            Images = images;
            Category = category;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Tag { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string[] Images { get; set; }
        public Category Category { get; set; }

    }
}