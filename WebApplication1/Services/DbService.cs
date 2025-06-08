using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.DTOs;

namespace WebApplication1.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IQueryable<CustomerPurchasesDto>> GetCustomerPurchases(int customerId)
    {
        var customer = _context.Customers.Select(e => new CustomerPurchasesDto()
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                PhoneNumber = e.PhoneNumber,
                PurchasesList = e.PurchaseHistory.Select(e => new PurchasesDto()
                {
                    Date = e.PurchaseDate,
                    Rating = e.Rating,
                    Price = e.AvailableProgram.Price,
                    
                    
                    
                }).ToList()
            });
        
        return customer;
    }
}
