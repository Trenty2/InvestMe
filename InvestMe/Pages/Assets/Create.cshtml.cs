using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InvestMe.Data;
using InvestMe.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace InvestMe
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly InvestMe.Data.ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public CreateModel(InvestMe.Data.ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Asset Asset { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }


            var currentUser = await _userManager.GetUserAsync(User);
            _context.Asset.Add(Asset);
            Asset.User = currentUser;


            await _context.SaveChangesAsync();



            return RedirectToPage("./Index");
        }
    }
}
