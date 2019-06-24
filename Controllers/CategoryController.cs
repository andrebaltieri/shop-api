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
        [Route("{id}/products")]
        public object Products(Guid id) => Database.Context.Products().Where(x => x.Category.Id == id).Select(x => new
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