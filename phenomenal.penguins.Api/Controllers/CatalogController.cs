using Microsoft.AspNetCore.Mvc;
using phenomenal.penguins.Domain.Catalog;

namespace phenomenal.penguins.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
    [HttpGet]
    public IActionResult GetItems()
    {
        var items = new List<Item>()
        {
            new Item("Shirt","Ohio State Shirt.", "Nike", 29.99m),
            new Item("Shorts", "Ohio state shorts", "Nike", 49.99m)
        };
        return Ok(items);
     }
    }
}
