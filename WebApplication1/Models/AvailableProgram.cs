using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

[Table("AvailableProgram")]
public class AvailableProgram
{
    [Key]
    public int AvailableProgramId { get; set; }
    [ForeignKey(nameof(WashingMachine))]
    public int WashingMachineId { get; set; }
    [ForeignKey(nameof(ProgramEntity))]
    public int ProgramId { get; set; }
    [Column(TypeName = "decimal")]
    [Precision(10,2)]
    public double Price { get; set; }
    
    public ICollection<PurchaseHistory> PurchaseHistories { get; set; } = null!;
    public WashingMaschine WashingMachine { get; set; } = null!;
    public ProgramEntity ProgramEntity { get; set; } = null!;
}