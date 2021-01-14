using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InvestMe.Models;

namespace InvestMe.Models
{
    public class Debt
    {
        public int ID { get; set; }

        public string Creditor { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Initial Debt")]
        public decimal InitialDebt { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Current Debt")]
        public decimal CurrentDebt { get; set; }

        public ApplicationUser User { get; set; }


        public decimal PaidDown()
        {
            var result = InitialDebt - CurrentDebt;

            return result;
        }

        
    }
}
