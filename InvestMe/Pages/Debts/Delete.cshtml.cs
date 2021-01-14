using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InvestMe.Data;
using InvestMe.Models;

namespace InvestMe.Pages.Debts
{
    public class DeleteModel : PageModel
    {
        private readonly InvestMe.Data.ApplicationDbContext _context;

        public DeleteModel(InvestMe.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Debt Debt { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Debt = await _context.Debts.FirstOrDefaultAsync(m => m.ID == id);

            if (Debt == null)
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

            Debt = await _context.Debts.FindAsync(id);

            if (Debt != null)
            {
                _context.Debts.Remove(Debt);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
