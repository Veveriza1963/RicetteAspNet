using System.ComponentModel.DataAnnotations;

namespace RicetteDB.Models;

public class RicAzoto
{
    [Key]
    public int Id { get; set; }
    
    [Range(0, 250)]
    public short Temperatura { get; set; }
    
    [Range(0.00, 9.99)]
    public string Tempo { get; set; } = null!;

    [Display(Name = "Velocità"), Range(0.00, 19.00)]
    public short Velocita { get; set; }
    
    public string Note { get; set; } = null!;

    public int ArticoloId { get; set; }
    public Articoli Articoli { get; set; } = null!;
}