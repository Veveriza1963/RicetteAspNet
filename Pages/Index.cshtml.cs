using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RicetteDB.Data;

namespace RicetteDB.Pages;

public class IndexModel : PageModel
{
    public List<Models.Articoli> ListaArticoli = new();
    
    private readonly ILogger<IndexModel> _Logger;

    public IndexModel(ILogger<IndexModel> Logger)
    {
        _Logger = Logger;
    }

    public void OnGet()
    {
        var Context = new RicetteContext();
        var Query = from Var in Context.Articoli
            select Var;
        ListaArticoli = Query.ToList();
    }

    public IActionResult OnPostDelete(int Id)
    {
        var Context = new RicetteContext();
        var Articolo = Context.Articoli.Find(Id);
        Context.Remove<Models.Articoli>(Articolo!);
        Context.SaveChanges();
        return RedirectToAction("Get");
    }
}
