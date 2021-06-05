using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BOL;
namespace AppUI.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisterEmployee()
        {
            EmpMaster emp = new EmpMaster { EmpCode = 0,EmpName="Tiger",EmpDob=new DateTime(1983,03,11), Email="tiger@gmail.com",EmpDepartment="HR",EmpDesignation="MANAGER" };
            EmpMasterBOL empbol = new EmpMasterBOL();
           if(empbol.AddEmployee(emp))
            {
                return Content("Employee Saved Successfully");
            }
            else
            {
                return Content("Unexpected Error");
            }
        }
    }
}