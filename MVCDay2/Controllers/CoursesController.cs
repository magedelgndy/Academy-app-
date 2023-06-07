using Microsoft.AspNetCore.Mvc;

namespace MVCDay2.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
