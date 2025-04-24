using appweb1.data;
using appweb1.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _ctx;
        public CreateModel(AppDbContext ctx){
            _ctx=ctx;
        }
        [BindProperty]
        public Cliente cliente {get;set;}
        public void OnGet(){}

        public IActionResult OnPost(){
            _ctx.Clientes.Add(cliente);
            _ctx.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
