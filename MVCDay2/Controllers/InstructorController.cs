using Microsoft.AspNetCore.Mvc;
using MVCDay2.Models;
using System.Collections.Generic;

namespace MVCDay2.Controllers
{
    public class InstructorController : Controller
    {
        ITIEntity context = new ITIEntity();
        public IActionResult Instructor()
        {
            
           List<Instructor> instructorsmodel = context.Instructors.ToList();
            return View(instructorsmodel);
        }

        public IActionResult MyInstructor(int id)
        {
            Instructor myInstructormodel = context.Instructors.SingleOrDefault(x=>x.Id == id);
            return View(myInstructormodel);
        }
    }

   
}
