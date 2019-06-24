using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shop.Models;

namespace shop.Controllers
{
    [Route("v1/products")]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        public object Get() => Database.Context.Products().Select(x => new
        {
            Id = x.Id,
            Title = x.Title,
            Brand = x.Brand,
            Tag = x.Tag,
            Price = x.Price,
            Image = x.Images[0]
        });

        [HttpGet]
        [Route("{id}")]
        public Product Details(Guid id) => Database.Context.Products().Where(x => x.Id == id).FirstOrDefault();
    }
}