using System.ComponentModel.DataAnnotations;

namespace RicetteDB.Models;

public class RicAzoto
{
    [Key]
    public int ArticoloId { get; set; }
    
    [Display(Name = "Temperatura:")]
    [Range(0, 250)]
    public short Temperatura { get; set; }
    
    [Display(Name = "Tempo Lavoro:")]
    [RegularExpression("\\d\\d:\\d\\d")]
    public string Tempo { get; set; } = null!;

    [Display(Name = "Velocità:")]
    [RegularExpression("\\d?\\d/.\\d\\d")]
    public string Velocita { get; set; } = String.Empty;

    [Display(Name = "Note:")]
    public string? Note { get; set; } = String.Empty;
}