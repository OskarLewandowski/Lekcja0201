using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lekcja0201.Data;
using Lekcja0201.Models;

namespace Lekcja0201.Pages.Patterns
{
    public class IndexModel : PageModel
    {
        private readonly Lekcja0201.Data.Lekcja0201Context _context;

        public IndexModel(Lekcja0201.Data.Lekcja0201Context context)
        {
            _context = context;
        }

        public IList<Pattern1> Pattern1 { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Pattern1 = await _context.Pattern1.ToListAsync();
        }
    }
}
