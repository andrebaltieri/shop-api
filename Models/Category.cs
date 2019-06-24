using System;

namespace shop.Models
{
    public class Category
    {
        public Category()
        {

        }

        public Category(Guid id, string title, string tag)
        {
            Id = id;
            Title = title;
            Tag = tag;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Tag { get; set; }
    }
}