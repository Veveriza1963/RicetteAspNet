using System.ComponentModel.DataAnnotations;

namespace RicetteDB.Models;

public class Articoli
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(16, ErrorMessage = "Nome Articolo Troppo Lungo")]
    public string Articolo { get; set; } = null!;
    
    public string Note { get; set; } = null!;
}