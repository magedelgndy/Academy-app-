using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCDay2.Models;

namespace MVCDay2.Controllers
{
    public class CoursesController : Controller
    {
        ITIEntity context = new ITIEntity();
        public async Task<IActionResult> ALLCourses()
        {
           var  courses = context.Courses.Include(c=>c.Department);
                return View(await courses.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || context.Courses == null)
            {
                return NotFound();
            }
            Course myCourse = await context.Courses.Include(c=>c.Department).FirstOrDefaultAsync(d=>d.Id==id);
            if (myCourse == null)
            {
                return NotFound();
            }
            return View(myCourse);  
        }

        public IActionResult Create()
        {
            ViewData["Dept_id"] = new SelectList(context.Departments, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Degree,MinDegree,Dept_id")]Course course) {

            if (ModelState.IsValid)
            {
                context.Add(course);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(ALLCourses));
            }
            ViewData["Dept_id"] = new SelectList(context.Departments, "Id", "Name", course.Dept_id);
            return View(course);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null|| context.Courses == null)
            {
                return NotFound();
            }
             var myCourse = await context.Courses.FindAsync(id);

            if(myCourse == null) {
                return NotFound();
            }
            ViewData["Dept_Id"] = new SelectList(context.Departments, "Id", "Name", myCourse.Dept_id);
            return View(myCourse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Name,Degree,MinDegree,Dept_id")] Course course)
        {
            if(id != course.Id)
            {
                return NotFound();
            }

           if (ModelState.IsValid)
            {
                try
                {
                    context.Courses.Update(course);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ALLCourses));
            }
            ViewData["Dept_id"] = new SelectList(context.Departments, "Id", "Name", course.Dept_id);
            return View(course);
        }
        private bool CourseExists(int id)
        {
          return (context.Courses?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || context.Courses == null)
            {
                return NotFound();
            }
            var Mycourse = await context.Courses
                .Include(c=>c.Department)
                .FirstOrDefaultAsync(d=>d.Id==id);
            if(Mycourse == null)
            {
                return NotFound();
            }
            return View (Mycourse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (context.Courses == null)
            {
                return Problem("Entity set 'DB_ITI_Context.Courses'  is null.");
            }
            var Mycourse = context.Courses.Include(c=>c.Department).FirstOrDefault(d=>d.Id==id);
            if(Mycourse != null)
            {
                context.Courses.Remove(Mycourse);   
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(ALLCourses));
        }


    }
}
