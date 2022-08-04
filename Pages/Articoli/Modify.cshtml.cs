using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RicetteDB.Data;

namespace RicetteDB.Pages.Articoli
{
    public class ModifyModel : PageModel
    {
        [BindProperty]
        public Models.Articoli ModifyArticolo { get; set; } = new();

        public void OnGet(int Id)
        {
            var Context = new RicetteContext();
            ModifyArticolo = Context.Articoli.Find(Id)!;
        }

        public IActionResult OnPost(int Id)
        {
            ModifyArticolo.Id = Id;
            var Context = new RicetteContext();
            Context.Update<Models.Articoli>(ModifyArticolo);
            Context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
