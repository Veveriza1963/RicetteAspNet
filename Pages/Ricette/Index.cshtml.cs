using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RicetteDB.Data;
using RicetteDB.Models;

namespace RicetteDB.Pages.Ricette
{
    public class IndexModel : PageModel
    {
        [BindProperty] public RicAzoto NewRicAzoto { get; set; } = new();

        [BindProperty] public RicForno NewRicForno { get; set; } = new();
        
        public IActionResult OnGet(int Id)
        {
            using var Context = new RicetteContext();
            var Query = Context.Articoli.Find(Id);
            if (Query == null) return RedirectToPage("/Index");
            ViewData["Articolo"] = Query!.Articolo;
            ViewData["Id"] = Query.Id;
            NewRicAzoto = Context.RicAzoto.Find(Id)!;
            NewRicForno = Context.RicForno.Find(Id)!;
            return Page();
        }

        public IActionResult OnPostModifyRicAzoto()
        {
            using var Context = new RicetteContext();
            if (ExistKeyAzoto(NewRicAzoto.ArticoloId))
            {
                Context.RicAzoto.Update(NewRicAzoto);
            }
            else
            {
                Context.RicAzoto.Add(NewRicAzoto);
            }
            Context.SaveChanges();
            return RedirectToPage("/Index");
        }

        public IActionResult OnPostModifyRicForno()
        {
            using var Context = new RicetteContext();
            if (ExistKeyForno(NewRicForno.ArticoloId))
            {
                Context.RicForno.Update(NewRicForno);
            }
            else
            {
                Context.RicForno.Add(NewRicForno);
            }
            Context.SaveChanges();
            return RedirectToPage("/Index");
        }

        private static bool ExistKeyAzoto(int Id)
        {
            using var Context = new RicetteContext();
            var Query = Context.RicAzoto.Find(Id);
            return Query != null;
        }

        private static bool ExistKeyForno(int Id)
        {
            using var Context = new RicetteContext();
            var Query = Context.RicForno.Find(Id);
            return Query != null;
        }
    }
}
