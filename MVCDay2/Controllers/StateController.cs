using Microsoft.AspNetCore.Mvc;
using MVCDay2.Models;
using Newtonsoft.Json;

namespace MVCDay2.Controllers
{
    public class StateController : Controller
    {
        ITIEntity context = new ITIEntity();
        public IActionResult SetSession(int id)
        {
           // var key  = "instructor";  
           //Instructor instructor = context.Instructors.SingleOrDefault(x=>x.Id == id);
           // var str = JsonConvert.SerializeObject(instructor);
            HttpContext.Session.SetString("ins", "maged");
            HttpContext.Session.SetInt32("insnumber", 1);
            HttpContext.Session.SetString("InsTxt","ddd");
            return Content("session Saved");
        }
        public IActionResult GetSession() {
            var str = HttpContext.Session.GetString("InsTxt");
            var name = HttpContext.Session.GetString("ins");
            var id = HttpContext.Session.GetInt32("insnumber");


            //var obj = JsonConvert.DeserializeObject<Instructor>(str);
            return Content($"The name is {name},The Number Is {id}, The Txt is {str}");
            }
        public IActionResult SetCookie() 
            {
                Response.Cookies.Append("name","maged");
                return Content("CookieSaved");
            }
            public IActionResult GetCookie() 
            {
                var name = Request.Cookies["name"];
                return Content(name);
            }
    }
}
