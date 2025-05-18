using Microsoft.AspNetCore.Mvc;

namespace StudentRaaCode.Web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
