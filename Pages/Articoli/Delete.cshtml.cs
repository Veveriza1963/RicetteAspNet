using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RicetteDB.Data;

namespace RicetteDB.Pages.Articoli
{
    public class DeleteModel : PageModel
    {
        [BindProperty] 
        public Models.Articoli DeleteArticolo { get; set; } = new();
        
        public void OnGet(int Id)
        {
            using var Context = new RicetteContext();
            DeleteArticolo = Context.Articoli.Find(Id)!;
        }

        public IActionResult OnPost()
        {
            var Id = DeleteArticolo.Id;
            using var Context = new RicetteContext();
            var Articolo = Context.Articoli.Find(Id);
            var Ricetta = Context.RicAzoto.Find(Id);
            if (Articolo == null) return RedirectToPage("/Index");
            Context.Remove<Models.Articoli>(Articolo!);
            if (Ricetta != null) Context.Remove<Models.RicAzoto>(Ricetta);
            Context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
