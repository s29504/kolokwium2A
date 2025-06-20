﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

[Table("WashingMaschine")]
public class WashingMaschine
{
    [Key]
    public int WashingMaschineId { get; set; }
    [Column(TypeName = "decimal")]
    [Precision(10,2)]
    public double MaxWeight { get; set; }

    [MaxLength(100)] 
    public string SerialNumber { get; set; } = null!;

    public ICollection<AvailableProgram> AvailablePrograms { get; set; } = null!;
}