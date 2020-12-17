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
    public class IndexModel : PageModel
    {
        private readonly InvestMe.Data.ApplicationDbContext _context;

        public IndexModel(InvestMe.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Asset> Asset { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            //LINQ query to select movie
            var assets = from a in _context.Asset
                select a;

            if (!string.IsNullOrEmpty(SearchString))
            {
                //LAMBDA expression to find Assets that match SearchString
                assets = assets.Where(s => s.Name.Contains(SearchString));
            }

            Asset = await assets.ToListAsync();
        }
    }
}
