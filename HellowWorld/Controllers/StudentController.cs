using HellowWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HellowWorld.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //NB : add emoty ndex View if not added already!
            return View();
        }

        /// <summary>
        /// This method will show empty create view (url /student/Create)
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        // <summary>
        /// This method will called on a POST request 
        /// (e.g from form) and form data will be passed to it
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (s.Name == null)
            {
                //If name is empty then go back to Create page
                //Pass back the student (s) so values user had filled
                //can be filled back into form again
                return View(s);
            }
            else
            {
                //Code here would Add student to DB
                //Then we would redirect to index
                // page (where we would list all students)
                // NB ensure Index view exists for redirect!
                return RedirectToAction(nameof(Index));
            }
        }
    }


    //return View(s);
}
