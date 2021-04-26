using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sknowed.Persistance.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task seedAsync (
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("ADMINISTRATORS"));

            var defaultUser = new ApplicationUser {
                FirstName = "Ezedin",
                LastName = "Fedlu",
                UserName = "ezedin.fedlu@gmail.com",
                Email = "ezedin.fedlu@gmail.com"
            };
            await userManager.CreateAsync(defaultUser, "123456");

            string adminUserName = "admin@microsoft.com";
            var adminUser = new ApplicationUser { UserName = adminUserName, Email = adminUserName };
            await userManager.CreateAsync(adminUser, "123456");
            adminUser = await userManager.FindByNameAsync(adminUserName);
            await userManager.AddToRoleAsync(adminUser, "ADMINISTRATORS");
            return;
        }
    }
}
