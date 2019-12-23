using Library.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Data
{
    public class CreateUserRoles : ICreateUserRoles
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public CreateUserRoles(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public void AddUserRole()
        {
           
            if (_db.Roles.Any(r => r.Name == "Admin")) return;

            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Musteri")).GetAwaiter().GetResult();
           


            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "miray@gmail.com",
                Email = "miray@gmail.com",
                EmailConfirmed = true,
                FirstName = "Miray",
                LastName = "Çoban"
            }, "Miray1234*").GetAwaiter().GetResult();

            ApplicationUser user = _db.ApplicationUser.Where
                (u => u.Email == "miray@gmail.com").FirstOrDefault();

           _userManager.AddToRoleAsync(user, "Admin").GetAwaiter().GetResult();
        }
    }
}
