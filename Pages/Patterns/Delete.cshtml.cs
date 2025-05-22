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
    public class DeleteModel : PageModel
    {
        private readonly Lekcja0201.Data.Lekcja0201Context _context;

        public DeleteModel(Lekcja0201.Data.Lekcja0201Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Pattern1 Pattern1 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pattern1 = await _context.Pattern1.FirstOrDefaultAsync(m => m.Id == id);

            if (pattern1 == null)
            {
                return NotFound();
            }
            else
            {
                Pattern1 = pattern1;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pattern1 = await _context.Pattern1.FindAsync(id);
            if (pattern1 != null)
            {
                Pattern1 = pattern1;
                _context.Pattern1.Remove(Pattern1);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
