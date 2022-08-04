using System.ComponentModel.DataAnnotations;

namespace RicetteDB.Models;

public class RicForno
{
    [Key]
    public int ArticoloId { get; set; }
    
    [Display(Name = "Temperatura:")]
    public short Temperatura { get; set; }
    
    [Display(Name = "Temperatura Riscaldamento:")]
    [MaxLength(length:4)]
    public string TempRiscaldo { get; set; } = null!;
    
    [Display(Name = "Temperatura Raffreddamento:")]
    [MaxLength(length:4)]
    public string TempRaffreddo { get; set; } = null!;
    
    [Display(Name = "Note:")]
    public string Note { get; set; } = null!;
}