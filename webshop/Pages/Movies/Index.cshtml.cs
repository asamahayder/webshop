using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webshop.Data;
using webshop.Models;

namespace webshop.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly webshop.Data.webshopContext _context;

        public IndexModel(webshop.Data.webshopContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
