using HellowWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HellowWorld.Controllers
{
    public class HelloWorldController : Controller
    {

        /// <summary>
        /// Most basic action (method)TYhis simply returns a string (in the http response) which the browser will then display
        /// </summary>
        /// <returns></returns>
        public string Index()
        { 
            string strRet = "The simplest case is to return a string from the controller.";
            strRet += "This string will be drawn as text in the browser";
            return strRet;

        }

        /// <summary>
        /// This action allows us to pass some params to it as part of the url eg.. url/helloworld/welcome2?name=john&numtimes=4
        /// We then look inside the Request to extract these params
        /// </summary>
        /// <returns></returns>
        public string Welcome2()
        {
            string name = Request.Query["name"];
            string num  = Request.Query["numtimes"];
            return "Hello " + name + " num = " + num;
        }

        /// <summary>
        /// This action defines method paramaters.
        /// if the url params (e.g  url/helloworld/welcome3?name=john&numtimes=4) match the params names to this mehtod, then those values will be passed into this method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="numtimes"></param>
        /// <returns></returns>
        public string Welcome3(string name, int numtimes)
        {            
            return "Hello " + name + " num = " + numtimes;
        }

        /// <summary>
        /// This action allows for a model to be passed in.. If any of the model properties names match the params on the url, then those values will be copied into the model
        /// The model will then be passed into this method
        /// example url -> url/helloworld/welcome4?name=john&numtimes=4
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public string Welcome4(Person p)
        {
            return "Hello person " + p.Name + " num = " + p.Numtimes;
        }

        //Code....

        /// <summary>
        /// This action show us a method that returns a view
        /// </summary>
        /// <returns></returns>
        
        public IActionResult Welcome5(string name, int numtimes)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["number"] = numtimes;
            
            //--to use ViewBag instead we just create property on the fly as needed
            //ViewBag.Message = "Hello " + name;
            //ViewBag.number  = numtimes;
            return View();
        }

        /*
        ///route : helloworld/welcome6?name=john&age=21
        public IActionResult Welcome6(string studentName, int age)
        {
            //URL will pass in studentName and age
            //Create a Person object form this
          
            Student p = new Student
            {
                Name = studentName,
                Age = age
            };

            //we can pass student p directly to view as a parameter
            //   Under the hood, student p is storted in the viewbag (i.e ViewBag.Model = p) 
            //   so that the controller can access it 
            return View(p);   //we can pass studnet p directly to view as a parameter
        }
        */


        ///route : helloworld/welcome6?name=john&age=21
        public IActionResult Welcome6(Student p)
        {
            //URL will pass in studentName and age
            //MVC will create a new student and
            // match url studentName, age to  Student studentName, age

            //we can pass student p directly to view as a parameter
            //   Under the hood, student p is storted in the viewbag (i.e ViewBag.Model = p) 
            //   so that the controller can access it 
            return View(p);   //we can pass studnet p directly to view as a parameter
        }
    }
}




//---Original Index method ----
//public IActionResult Index()
//{
//    return View();
//}
