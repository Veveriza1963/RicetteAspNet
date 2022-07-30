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
}
