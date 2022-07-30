using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RicetteDB.Data;

namespace RicetteDB.Pages.Articoli
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Models.Articoli NewArticolo { get; set; } = new();
        
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            var Context = new RicetteContext();
            Context.Add(NewArticolo);
            Context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
