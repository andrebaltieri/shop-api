using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shop.Models;

namespace shop.Controllers
{
    [Route("v1/products")]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        [AllowAnonymous]
        public object Get() => Database.Context.Products().Select(x => new
        {
            Id = x.Id,
            Title = x.Title,
            Brand = x.Brand,
            Tag = x.Tag,
            Price = x.Price,
            Image = x.Images[0]
        }).OrderBy(x => x.Title);

        [HttpGet]
        [Route("brands/{brand}")]
        [AllowAnonymous]
        public object GetByBrand(string brand) => Database.Context.Products().Where(x => x.Brand.ToLower() == brand.ToLower()).Select(x => new
        {
            Id = x.Id,
            Title = x.Title,
            Brand = x.Brand,
            Tag = x.Tag,
            Price = x.Price,
            Image = x.Images[0]
        }).OrderBy(x => x.Title);

        [HttpGet]
        [Route("{tag}")]
        [AllowAnonymous]
        public Product Details(string tag) => Database.Context.Products().Where(x => x.Tag.ToLower() == tag.ToLower()).FirstOrDefault();
    }
}