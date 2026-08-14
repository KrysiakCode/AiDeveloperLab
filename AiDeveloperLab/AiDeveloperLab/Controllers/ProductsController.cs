using Microsoft.AspNetCore.Mvc;

namespace AiDeveloperLab.Controllers;

[ApiController]
[Route("products")]
public class ProductsController : ControllerBase
{
    private static readonly Product[] Products =
    [
        new("AI Developer Handbook", 29.99m),
        new("Cloud Architecture Guide", 39.99m)
    ];

    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        return Ok(Products);
    }
}
