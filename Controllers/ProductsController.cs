using Microsoft.AspNetCore.Mvc;
using CheckoutLab.Api.Models;

namespace CheckoutLab.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Keyboard",
                Price = 49.99m
            },
            new Product
            {
                Id = 2,
                Name = "Mouse",
                Price = 29.99m
            }
        };

        return Ok(products);
    }
}