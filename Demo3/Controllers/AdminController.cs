using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Demo3.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Demo3.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        public async Task<ActionResult> CreateUser()
        {
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(

                new ApplicationDbContext()
                ));
            //um.FindByName("admin@a.a");
            await um.CreateAsync(new ApplicationUser() { Email = "f@a.a", UserName = "f@a.a", Fname = "fahy", Lname = "ffff" }, "Fathy2005$");

            return Content("user added");
        }


        


        public async Task<ActionResult> CreatRole(string name)
        {
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
           await rm.CreateAsync(new IdentityRole() { Name = name });
            return Content("role added");
        }


        public ActionResult show()
        {
            return Content("show inside admin cont");
        }


      


        
    }
}