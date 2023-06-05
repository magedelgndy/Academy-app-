using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCDay2.Models;
using MVCDay2.ViewModel;
using System.Security.Cryptography;

namespace MVCDay2.Controllers
{
    public class TraineeController : Controller
    {
        ITIEntity context = new ITIEntity();
        
        public IActionResult ShowDegree(int tId,int cId)
        {
            Course course = context.Courses.Where(c => c.Id == cId).FirstOrDefault();
            TraineeCourseViewModel trCVM = context.CourseResults.Where(n=>n.TraineeId==tId&&n.CrsId==cId).Include(cr=>cr.Trainee).Include(c=>c.Course).Select(cr =>new TraineeCourseViewModel(){
                TName=cr.Trainee.Name,
                CName=cr.Course.Name,
                Degree= (int)cr.Degree,
                Min_degree= (int)course.Min_degree
                }).FirstOrDefault();

            if (trCVM.Degree >trCVM.Min_degree)
            {
                trCVM.color ="green";
            }
            else
            {
                trCVM.color ="red";
            }

            return View(trCVM);
        }
        
        public IActionResult ShowCourseResult(int cId)
        {
            Course course = context.Courses.Where(c => c.Id == cId).FirstOrDefault();
            List<TraineeCourseViewModel> TRCVM = context.CourseResults.Where(n=>n.CrsId==cId).Include(cr=>cr.Trainee).Include(cr=>cr.Course).Select(cr =>new TraineeCourseViewModel(){
                TName=cr.Trainee.Name,
                CName=cr.Course.Name,
                Degree= (int)cr.Degree,
                Min_degree= (int)course.Min_degree
                }).ToList();
            foreach (var item in TRCVM)
            {
                if (item.Degree > item.Min_degree)
                {
                    item.color = "green";
                }
                else
                {
                    item.color = "red";

                }
            }
            return View(TRCVM);
        } 
        public IActionResult ShowTraineeResult(int tId)
        {
            Course course = context.Courses.FirstOrDefault();
            List<TraineeCourseViewModel> TraineeCRVM = context.CourseResults
                                                                .Where(n => n.TraineeId == tId)
                                                                .Include(cr => cr.Trainee)
                                                                .Include(cr => cr.Course)
                                                                .Select(cr => new TraineeCourseViewModel()
    {
                TName=cr.Trainee.Name,
                CName=cr.Course.Name,
                Degree= (int)cr.Degree,
                Min_degree= (int)course.Min_degree
              
    }).ToList();
            
            foreach (var item in TraineeCRVM)
            {
                if (item.Degree > item.Min_degree)
                {
                    item.color = "green";
                }
                else
                {
                    item.color = "red";

                }
            }
            return View(TraineeCRVM);
        }
    }
}
