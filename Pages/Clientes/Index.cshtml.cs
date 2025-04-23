using appweb1.data;
using appweb1.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _ctx;
        public IndexModel(AppDBContext ctx)
        {
            _ctx = ctx;
        }
        public List<Cliente> Clientes { get; set; }
        public void OnGet() //Se ejecuta al cargar la pagina
        {
            Clientes = _ctx.Clientes.ToList();
        }
    }
}
