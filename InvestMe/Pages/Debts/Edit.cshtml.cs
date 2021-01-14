using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InvestMe.Data;
using InvestMe.Models;

namespace InvestMe.Pages.Debts
{
    public class EditModel : PageModel
    {
        private readonly InvestMe.Data.ApplicationDbContext _context;

        public EditModel(InvestMe.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Debt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DebtExists(Debt.ID))
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

        private bool DebtExists(int id)
        {
            return _context.Debts.Any(e => e.ID == id);
        }
    }
}
