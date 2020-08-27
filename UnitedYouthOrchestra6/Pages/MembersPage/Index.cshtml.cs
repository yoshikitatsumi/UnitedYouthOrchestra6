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
    public class IndexModel : PageModel
    {
        private readonly UnitedYouthOrchestra6.Data.UnitedYouthOrchestra6Context _context;

        public IndexModel(UnitedYouthOrchestra6.Data.UnitedYouthOrchestra6Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; }

        public async Task OnGetAsync()
        {
            Member = await _context.Member
                .Include(m => m.instrument)
                .Include(m => m.schoolyear).ToListAsync();
        }
    }
}
