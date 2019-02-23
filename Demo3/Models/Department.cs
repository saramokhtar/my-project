using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo3.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

       public List<ApplicationUser> Users { get; set; }
    }
}