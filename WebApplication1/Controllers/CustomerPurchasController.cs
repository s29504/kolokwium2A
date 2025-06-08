using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerPurchasController : Controller
{
    private readonly IDbService _dbService;

    public CustomerPurchasController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{customerId}/purchases")]
    public async Task<IActionResult> GetCustomerPurchases(int customerId)
    {
        try
        {
            var customer = await _dbService.GetCustomerPurchases(customerId);
            return Ok(customer);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
}