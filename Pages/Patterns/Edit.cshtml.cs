using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lekcja0201.Data;
using Lekcja0201.Models;

namespace Lekcja0201.Pages.Patterns
{
    public class EditModel : PageModel
    {
        private readonly Lekcja0201.Data.Lekcja0201Context _context;

        public EditModel(Lekcja0201.Data.Lekcja0201Context context)
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

            var pattern1 =  await _context.Pattern1.FirstOrDefaultAsync(m => m.Id == id);
            if (pattern1 == null)
            {
                return NotFound();
            }
            Pattern1 = pattern1;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pattern1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Pattern1Exists(Pattern1.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Pattern1Exists(int id)
        {
            return _context.Pattern1.Any(e => e.Id == id);
        }
    }
}
