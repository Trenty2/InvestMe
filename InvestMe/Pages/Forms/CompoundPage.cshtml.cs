using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvestMe.Pages.Forms
{
    public class CompoundPageModel : PageModel
    {
        public double Result { get; set; }

        [BindProperty]
        public int InitialDeposit { get; set; }
        [BindProperty]
        public int RegularDeposit { get; set; }
        [BindProperty]
        public string DepositFrequency { get; set; }
        [BindProperty]
        public int CompoundFrequency { get; set; }
        [BindProperty]
        public int NumOfYears { get; set; }
        [BindProperty]
        public double AnnualInterest { get; set; }



        public void OnGet()
        {

        }


        public void OnPostAsync()
        {
            if (!ModelState.IsValid)

            {
                RedirectToPage("/Index");
            }

        }


        //Compound function that calculates compounding interest based on the number of years invested, the initial amount invested and the interest rate every month, 6 months or 12 months. (A = P (1 + r/n) (nt))
        public double Compound()
        {
            Result = InitialDeposit;

            var annualInterest = AnnualInterest / 100;

            var compoundFrequency = CompoundFrequency;

            var firstResult = annualInterest / compoundFrequency;

            var secondResult = 1 + firstResult;

            var results = CompoundFrequency * NumOfYears;
            double res = Math.Pow(secondResult, results);

            Result = Result * res;

            return Result;
        }
    }
}

