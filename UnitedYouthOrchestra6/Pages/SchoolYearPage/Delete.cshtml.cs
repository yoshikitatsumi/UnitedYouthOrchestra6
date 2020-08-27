using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UnitedYouthOrchestra6.Data;
using UnitedYouthOrchestra6.Models;

namespace UnitedYouthOrchestra6.Pages.SchoolYearPage
{
    public class DeleteModel : PageModel
    {
        private readonly UnitedYouthOrchestra6.Data.UnitedYouthOrchestra6Context _context;

        public DeleteModel(UnitedYouthOrchestra6.Data.UnitedYouthOrchestra6Context context)
        {
            _context = context;
        }

        [BindProperty]
        public SchoolYear SchoolYear { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SchoolYear = await _context.SchoolYear.FirstOrDefaultAsync(m => m.Id == id);

            if (SchoolYear == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SchoolYear = await _context.SchoolYear.FindAsync(id);

            if (SchoolYear != null)
            {
                _context.SchoolYear.Remove(SchoolYear);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
