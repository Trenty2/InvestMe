﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace InvestMe.Models
{
    public class Asset
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Purchase Price")]
        public decimal PurchasePrice { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Current Price")]
        public decimal CurrentPrice { get; set; }

        public ApplicationUser? User { get; set; }
    }
}
