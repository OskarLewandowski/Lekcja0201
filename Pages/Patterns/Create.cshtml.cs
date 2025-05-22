using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lekcja0201.Data;
using Lekcja0201.Models;

namespace Lekcja0201.Pages.Patterns
{
    public class CreateModel : PageModel
    {
        private readonly Lekcja0201.Data.Lekcja0201Context _context;

        public CreateModel(Lekcja0201.Data.Lekcja0201Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pattern1 Pattern1 { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            if (Pattern1.A < 0 && Pattern1.B > 0 
                && Math.Abs(Pattern1.B) > Math.Abs(Pattern1.A))
            {
                Pattern1.ResultPart1 ="(x"
                    + Convert.ToString(Pattern1.A) + ")(x+" 
                    + Convert.ToString(Pattern1.B) + ")";

                Pattern1.ResultPart2 = "x^2+" 
                    + Convert.ToString(Pattern1.B) + "x" 
                    + Convert.ToString(Pattern1.A) + "x"
                    + Convert.ToString(Pattern1.A * Pattern1.B);

                Pattern1.ResultPart3 = "x^2+"
                    + Convert.ToString(Pattern1.B + Pattern1.A) + "x"
                    + Convert.ToString(Pattern1.A * Pattern1.B);
            }
            else if (Pattern1.A > 0 && Pattern1.B < 0 
                && Math.Abs(Pattern1.B) > Math.Abs(Pattern1.A))
            {
                Pattern1.ResultPart1 = "(x+" 
                    + Convert.ToString(Pattern1.A) + ")(x" 
                    + Convert.ToString(Pattern1.B) + ")";

                Pattern1.ResultPart2 = "x^2" 
                    + Convert.ToString(Pattern1.B) + "x+" 
                    + Convert.ToString(Pattern1.A) + "x"
                    + Convert.ToString(Pattern1.A * Pattern1.B);

                Pattern1.ResultPart3 = "x^2+"
                    + Convert.ToString(Pattern1.B + Pattern1.A) + "x"
                    + Convert.ToString(Pattern1.A * Pattern1.B);
            }
            else if (Pattern1.A == 0 && Pattern1.B > 0)
            {
                Pattern1.ResultPart1 = "(x+" 
                    + Convert.ToString(Pattern1.A) + ")(x" 
                    + Convert.ToString(Pattern1.B) + ")";

                Pattern1.ResultPart2 = "x^2+" 
                    + Convert.ToString(Pattern1.B) + "x+" 
                    + Convert.ToString(Pattern1.A) + "x"
                    + Convert.ToString(Pattern1.A * Pattern1.B);

                Pattern1.ResultPart3 = "x^2+"
                    + Convert.ToString(Pattern1.B + Pattern1.A) + "x";
            }
            else if (Pattern1.A == 0 && Pattern1.B < 0)
            {
                Pattern1.ResultPart1 = "(x+"
                    + Convert.ToString(Pattern1.A) + ")(x"
                    + Convert.ToString(Pattern1.B) + ")";

                Pattern1.ResultPart2 = "x^2"
                    + Convert.ToString(Pattern1.B) + "x+"
                    + Convert.ToString(Pattern1.A) + "x"
                    + Convert.ToString(Pattern1.A * Pattern1.B);

                Pattern1.ResultPart3 = "x^2"
                    + Convert.ToString(Pattern1.B + Pattern1.A) + "x";
            }
            else if (Pattern1.A == 0 && Pattern1.B == 0)
            {
                Pattern1.ResultPart1 = "(x+"
                    + Convert.ToString(Pattern1.A) + ")(x"
                    + Convert.ToString(Pattern1.B) + ")";

                Pattern1.ResultPart2 = "x^2+"
                    + Convert.ToString(Pattern1.B) + "x-"
                    + Convert.ToString(Pattern1.A) + "x"
                    + Convert.ToString(Pattern1.A * Pattern1.B);

                Pattern1.ResultPart3 = "x^2";
            }
            else if (Pattern1.A < 0 && Pattern1.B < 0 && Math.Abs(Pattern1.A) > Math.Abs(Pattern1.B))
            {
                Pattern1.ResultPart1 = "(x"
                    + Convert.ToString(Pattern1.A) + ")(x"
                    + Convert.ToString(Pattern1.B) + ")";

                Pattern1.ResultPart2 = "x^2"
                    + Convert.ToString(Pattern1.B) + "x+"
                    + Convert.ToString(Pattern1.A) + "x"
                    + Convert.ToString(Pattern1.A * Pattern1.B);

                Pattern1.ResultPart3 = "x^2" 
                    + Convert.ToString(Pattern1.B + Pattern1.A) + "x+"
                    + Convert.ToString(Pattern1.A * Pattern1.B);
            }
            else if (Pattern1.A < 0 && Pattern1.B < 0 && Math.Abs(Pattern1.A) < Math.Abs(Pattern1.B))
            {
                Pattern1.ResultPart1 = "(x+" 
                    + Convert.ToString(Pattern1.A) + ")(x+" 
                    + Convert.ToString(Pattern1.B) + ")";

                Pattern1.ResultPart2 = "x^2+" 
                    + Convert.ToString(Pattern1.B) + "x" 
                    + Convert.ToString(Pattern1.A) + "x+"
                    + Convert.ToString(Pattern1.A * Pattern1.B);

                Pattern1.ResultPart3 = "x^2"
                    + Convert.ToString(Pattern1.B + Pattern1.A) + "x+"
                    + Convert.ToString(Pattern1.A * Pattern1.B);
            }
            else if (Pattern1.A < 0 && Pattern1.B < 0 && Math.Abs(Pattern1.A) == Math.Abs(Pattern1.B))
            {
                Pattern1.ResultPart1 = "(x"
                    + Convert.ToString(Pattern1.A) + ")(x"
                    + Convert.ToString(Pattern1.B) + ")";

                Pattern1.ResultPart2 = "x^2"
                    + Convert.ToString(Pattern1.B) + "x"
                    + Convert.ToString(Pattern1.A) + "x+"
                    + Convert.ToString(Pattern1.A * Pattern1.B);

                Pattern1.ResultPart3 = "x^2"
                    + Convert.ToString(Pattern1.B + Pattern1.A) + "x+"
                    + Convert.ToString(Pattern1.A * Pattern1.B);
            }
            else if (Pattern1.A > 0 && Pattern1.B > 0 && Math.Abs(Pattern1.A) == Math.Abs(Pattern1.B))
            {
                Pattern1.ResultPart1 = "(x+"
                    + Convert.ToString(Pattern1.A) + ")(x+"
                    + Convert.ToString(Pattern1.B) + ")";

                Pattern1.ResultPart2 = "x^2+"
                    + Convert.ToString(Pattern1.B) + "x+"
                    + Convert.ToString(Pattern1.A) + "x+"
                    + Convert.ToString(Pattern1.A * Pattern1.B);

                Pattern1.ResultPart3 = "x^2+"
                    + Convert.ToString(Pattern1.B + Pattern1.A) + "x+"
                    + Convert.ToString(Pattern1.A * Pattern1.B);
            }


            _context.Pattern1.Add(Pattern1);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
