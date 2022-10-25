using Microsoft.AspNetCore.Mvc;

namespace HellowWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        { 
            string strRet = "The simplest case is to return a string from the controller.";
            strRet += "This string will be drawn as text in the browser";
            return strRet;

        }

        public string Welcome2()
        {
            string name = Request.Query["name"];
            string num  = Request.Query["numtimes"];
            return "Hello " + name + " num = " + num;
        }

    }
}





//public IActionResult Index()
//{
//    return View();
//}
