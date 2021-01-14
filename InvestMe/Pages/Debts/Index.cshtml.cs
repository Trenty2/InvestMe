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
    public class IndexModel : PageModel
    {
        private readonly InvestMe.Data.ApplicationDbContext _context;

        public IndexModel(InvestMe.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Debt> Debt { get;set; }

        public async Task OnGetAsync()
        {
            Debt = await _context.Debts.ToListAsync();
        }
    }
}
