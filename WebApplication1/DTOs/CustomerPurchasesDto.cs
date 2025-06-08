namespace WebApplication1.DTOs;

public class CustomerPurchasesDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public List<PurchasesDto> PurchasesList { get; set; } = null!;
}

public class PurchasesDto
{
    public DateTime Date { get; set; }
    public int Rating { get; set; }
    public double Price { get; set; }
    
    public WashingMachineDto WashingMachine { get; set; } = null!;
    public ProgramDto ProgramsDto { get; set; } = null!;
    
}

public class WashingMachineDto
{
    public string SerialNumber { get; set; } = null!;
    public double MaxWeight { get; set; }
}

public class ProgramDto
{
    public string Name { get; set; } = null!;
    public int Duration { get; set; }
}