using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shop.Models;

namespace shop.Controllers
{
    [Route("v1/categories")]
    public class CategoryController : Controller
    {
        [HttpGet]
        [Route("")]
        public IList<Category> Get() => Database.Context.Categories();

        [HttpGet]
        [Route("{tag}/products")]
        public object Products(string tag) => Database.Context.Products().Where(x => x.Category.Tag.ToLower() == tag.ToLower()).Select(x => new
        {
            Id = x.Id,
            Title = x.Title,
            Brand = x.Brand,
            Tag = x.Tag,
            Price = x.Price,
            Image = x.Images[0]
        });
    }
}