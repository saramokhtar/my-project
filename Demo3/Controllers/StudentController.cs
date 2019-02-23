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
    [Authorize(Roles ="student")]
    public class StudentController : Controller
    {
        public ActionResult Show()
        {
            return Content("show action inside student");
        }

        public async Task<ActionResult> MyProfile()
        {

           string name= Request.GetOwinContext().Request.User.Identity.Name;


            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(

               new ApplicationDbContext()
               ));

          ApplicationUser s=  await um.FindByNameAsync(name);

            RegisterViewModel r = new RegisterViewModel() { Email = s.Email, Fname = s.Fname,Lname=s.Lname };
            return View(r);
        }


        // GET: Student
        public ActionResult Index()
        {


            return View();
        }
    }
}