using Microsoft.AspNetCore.Mvc;
using LeaveManagementSystem.Web.Models;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC Mastery",
                DateOfBirth = new DateTime(1999,12,07)
            };

            return View(data);
        }
    }
}
