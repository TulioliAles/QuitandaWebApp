using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuitandaWebApp.Data;
using QuitandaWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuitandaWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private ApplicationDbContext _context;

        public IList<Produto> Produtos;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produto.ToListAsync<Produto>();
        }
    }
}
