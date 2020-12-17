using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InvestMe.Data;
using InvestMe.Models;
using Microsoft.AspNetCore.Authorization;

namespace InvestMe
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly InvestMe.Data.ApplicationDbContext _context;

        public DetailsModel(InvestMe.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Asset Asset { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Asset = await _context.Asset.FirstOrDefaultAsync(m => m.ID == id);

            if (Asset == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
