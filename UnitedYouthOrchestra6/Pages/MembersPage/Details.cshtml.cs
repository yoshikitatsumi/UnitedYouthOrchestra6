using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UnitedYouthOrchestra6.Data;
using UnitedYouthOrchestra6.Models;

namespace UnitedYouthOrchestra6.Pages.MembersPage
{
    public class DetailsModel : PageModel
    {
        private readonly UnitedYouthOrchestra6.Data.UnitedYouthOrchestra6Context _context;

        public DetailsModel(UnitedYouthOrchestra6.Data.UnitedYouthOrchestra6Context context)
        {
            _context = context;
        }

        public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Member = await _context.Member
                .Include(m => m.instrument)
                .Include(m => m.schoolyear).FirstOrDefaultAsync(m => m.Id == id);

            if (Member == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
