using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestMe.Models;
using Microsoft.AspNetCore.Identity;

namespace InvestMe.Data
{
    public class DummyData
    {

        public static async Task Initialize(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            //context.Database.EnsureCreated();


            //string role1 = "Admin";
            //string desc1 = "This is the administrator role";

            //string role2 = "Member";
            //string desc2 = "This is the members role";

            //string password = "Pogchamp!1";

            //if (await roleManager.FindByNameAsync(role1) == null)
            //{
            //    await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            //}

            //if (await roleManager.FindByNameAsync(role2) == null)
            //{
            //    await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            //}

            //if (await userManager.FindByNameAsync("aa@aa.aa") == null)
            //{
            //    var user = new ApplicationUser
            //    {
            //        UserName = "aa@aa.aa",
            //        Email = "aa@aa.aa",
            //        FirstName = "Adam",
            //        LastName = "Aldridge",
            //        Street = "Fake St",
            //        City = "Vancouver",
            //        Country = "Canada",
            //        PhoneNumber = "6902341234"
            //    };

            //    var result = await userManager.CreateAsync(user);
            //    if (result.Succeeded)
            //    {
            //        await userManager.AddPasswordAsync(user, password);
            //        await userManager.AddToRoleAsync(user, role1);
            //    }

            //}

            //if (await userManager.FindByNameAsync("bb@bb.bb") == null)
            //{
            //    var user = new ApplicationUser
            //    {
            //        UserName = "bb@bb.bb",
            //        Email = "bb@bb.bb",
            //        FirstName = "Bob",
            //        LastName = "Barker",
            //        Street = "Vermont St",
            //        City = "Surrey",
            //        Country = "Canada",
            //        PhoneNumber = "7788951456"
            //    };

            //    var result = await userManager.CreateAsync(user);
            //    if (result.Succeeded)
            //    {
            //        await userManager.AddPasswordAsync(user, password);
            //        await userManager.AddToRoleAsync(user, role1);
            //    }
            //}
            
        }
    }

}




