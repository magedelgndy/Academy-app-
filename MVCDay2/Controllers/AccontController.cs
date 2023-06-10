using Microsoft.AspNetCore.Mvc;
using MVCDay2.Models;

namespace MVCDay2.Controllers
{
    public class AccontController : Controller
    {
        ITIEntity context = new ITIEntity();
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Account acc)
        {
           Account acconnt = context.Accounts.FirstOrDefault(a =>a.UserName == acc.UserName && a.Password == acc.Password); 
            
            if (acconnt != null) {
               return RedirectToAction("AllInstructors", "Instructor");  
            }
            return View();
        }
    }
}
