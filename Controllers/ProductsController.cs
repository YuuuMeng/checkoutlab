using Microsoft.AspNetCore.Mvc;
using CheckoutLab.Api.Models;

namespace CheckoutLab.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    // In-memory fake database
    private static List<Product> products = new List<Product>
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

    // GET: /api/products
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(products);
    }

    // GET: /api/products/1
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    // POST: /api/products
    [HttpPost]
    public IActionResult Create(Product product)
    {
        products.Add(product);

        return Ok(product);
    }

    // DELETE: /api/products/1
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        products.Remove(product);

        return Ok(product);
    }

    [HttpPut("{id}")]
public IActionResult Update(int id, Product updatedProduct)
{
    var product = products.FirstOrDefault(p => p.Id == id);

    if (product == null)
    {
        return NotFound();
    }

    product.Name = updatedProduct.Name;
    product.Price = updatedProduct.Price;

    return Ok(product);
}
}