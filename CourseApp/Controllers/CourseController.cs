using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    //test
    // localhost:5237/course
    public class CourseController:Controller
    {
        //action method
        // localhost:5237/course/index => course/index.cshtml
        public ActionResult ByReleased(int year, int month) 
        {
            return Content("year : " + year + "month : " + month);
        }
        public IActionResult Index() 
        {
            return View();   
        }

        // localhost:5237/course/apply
        public IActionResult Apply()
        {
            return View();
        }
        //localhost:5000/course/apply method:POST
        //Name=value&Email=value&Phone=value&Confirm=value
        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                //database kayıt
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else { 
                return View(student);
            }
            
        }

        public IActionResult Details()
        {
          
            var course = new Course();

            course.Name = "Core Mvc Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;
            
           return View(course);//detailse taşıdık
        } 

        // localhost:5237/course/list => course/list.cshtml
        public IActionResult List()
        {
            var students = Repository.Students.Where(i => i.Confirm == true);
            return View(students);
        }
    }
}
