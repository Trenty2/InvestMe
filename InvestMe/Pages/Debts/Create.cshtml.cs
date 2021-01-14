using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InvestMe.Data;
using InvestMe.Models;

namespace InvestMe.Pages.Debts
{
    public class CreateModel : PageModel
    {
        private readonly InvestMe.Data.ApplicationDbContext _context;

        public CreateModel(InvestMe.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Debt Debt { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Debts.Add(Debt);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
