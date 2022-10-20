using System.ComponentModel.DataAnnotations;

namespace RicetteDB.Models;

public class Articoli
{
    [Key]
    public int Id { get; set; }
    
    [Display(Name = "Articolo:")]
    [StringLength(32, ErrorMessage = "Nome Articolo Troppo Lungo Max 16 Caratteri")]
    public string Articolo { get; set; } = String.Empty;
    
    [Display(Name = "Note:")]
    public string? Note { get; set; } = String.Empty;
    
    [Display(Name = "Talcatura:")]
    public bool Talco { get; set; }
    
    [Display(Name = "Siliconatura:")]
    public bool Silicone { get; set; }
    
    [Display(Name = "Teflonatura:")]
    public bool Teflon { get; set; }
}