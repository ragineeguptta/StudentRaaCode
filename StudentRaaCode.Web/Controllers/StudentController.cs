using Microsoft.AspNetCore.Mvc;
using StudentRaaCode.Web.Models;

namespace StudentRaaCode.Web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Raginee" });
            students.Add(new Student { Id = 2, Name = "Gunjan" });
            return View(students);
        }
    }
}
