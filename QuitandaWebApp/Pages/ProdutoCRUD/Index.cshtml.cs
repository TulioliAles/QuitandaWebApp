using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuitandaWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuitandaWebApp.Pages.ProdutoCRUD
{
    public class IndexModel : PageModel
    {
        private readonly QuitandaWebApp.Data.ApplicationDbContext _context;

        public IndexModel(QuitandaWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; }

        public async Task OnGetAsync()
        {
            Produto = await _context.Produto.ToListAsync();
        }
    }
}
