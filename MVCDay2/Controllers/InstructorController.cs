using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using MVCDay2.Models;
using MVCDay2.ViewModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCDay2.Controllers
{
    public class InstructorController : Controller
    {

        private readonly IWebHostEnvironment _webHostEnvironment;


        public InstructorController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        ITIEntity context = new ITIEntity();
        public IActionResult Salary (int Salary)
        {
            if (Salary>5000)
            {
                return Json(true);
            }
                return Json(false);

        }
        public IActionResult AllInstructors()
        {
            
           List<Instructor> instructorsmodel = context.Instructors.ToList();
            return View(instructorsmodel);
        }

        public IActionResult MyInstructor(int id)
        {
            Instructor myInstructormodel = context.Instructors.SingleOrDefault(x=>x.Id == id);
            return View(myInstructormodel);
        }

        public IActionResult New()
        {
            ViewData["DeptList"] = context.Departments.ToList();
            ViewData["CourseList"] = context.Courses.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(Instructor ins,IFormFile imageFile)
        {
            
            if (imageFile != null )
            {
                string fileName = Path.GetFileName(imageFile.FileName);

                // Specify the path where the image will be saved
                string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", fileName);

                // Save the image file to the specified path
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }

                // Set the Image property of the Instructor object
                ins.Img = fileName;
            }
            if (ModelState.IsValid==true)
            {
                try{
                context.Instructors.Add(ins);
                context.SaveChanges();
                return RedirectToAction(nameof(AllInstructors));
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("Dept_Id","please select department");
                }
            }
            ViewData["DeptList"] = context.Departments.ToList();
            ViewData["CourseList"] = context.Courses.ToList();
            return View(ins);
        }

        public IActionResult Update(int id)
        {
            Instructor i = context.Instructors.FirstOrDefault(n => n.Id == id);
            List<Course> c1 = context.Courses.ToList();
            List<Department> d1 = context.Departments.ToList();
            Instructor_data data = new Instructor_data()
            {
                course = c1,
                Dept = d1,
                Ins=i,

            };
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Instructor ins, IFormFile imageFile)
        {

            if (imageFile != null && imageFile.Length > 0)
            {
                string fileName = Path.GetFileName(imageFile.FileName);

                // Specify the path where the image will be saved
                string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", fileName);

                // Save the image file to the specified path
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }

                // Set the Image property of the Instructor object
                ins.Img = fileName;
            }
            if (ins.Name == null)
            {
                List<Course> c1 = context.Courses.ToList();
                List<Department> d1 = context.Departments.ToList();
                Instructor_data data = new Instructor_data()
                {
                    course = c1,
                    Dept = d1,

                };
                return View(data);

            }
            context.Instructors.Update(ins);
            context.SaveChanges();

            return RedirectToAction(nameof(AllInstructors));
        }

        public async Task<IActionResult> Delete(int id)
        {
             if (id == null || context.Instructors == null)
            {
                return NotFound();
            }
            var ins = await context.Instructors.FindAsync(id);

            if (ins == null)
            {
                return NotFound();
            }

            return View(ins);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
             if (id == null || context.Instructors == null)
            {
                 return Problem("Entity set 'DB_ITI_Context.Courses'  is null.");
            }
            var ins = await context.Instructors.FindAsync(id);

            if (ins != null)
            {
                context.Instructors.Remove(ins);
            }
            
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(AllInstructors));
        }

        [HttpPost]
        public IActionResult Search(string name)
        {
            if (name != null )
            {
                List<Instructor> instructor = new List<Instructor>
                {
                    context.Instructors.FirstOrDefault(n => n.Name == name)
                };
                var dis = context.Instructors.Where(n=>n.Name == name).ToList();
                if (dis != null)
                {
                    return View("AllInstructors",dis);
                }else{
                  List<Instructor> instructorsmodel = context.Instructors.ToList();
                    return View("AllInstructors",instructorsmodel);
          
                 }
             }  
             return View();
        }

    }

   
}
