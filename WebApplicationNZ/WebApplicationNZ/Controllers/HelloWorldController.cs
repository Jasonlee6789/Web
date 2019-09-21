using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplicationNZ.Controllers
{
    public class HelloWorldController : Controller
    {
        // https://localhost:5001  Every public method in a controller is callable as an HTTP endpoint. 
        // GET: /HelloWorld/ 

        /*public string Index()
        {
            return "lijing This is my default action...";
        }*/
        //Currently the Index method returns a string with a message that's hard-coded in the controller class.
        // In the HelloWorldController class, replace the Index method with the following code:

            public IActionResult Index()
        {
            return View(); //It uses a view template to generate an HTML response. 
        }
        //The above update code calls the controller's View method.
         // Controller methods (also known as action methods), such as the Index method above, 
         // generally return an IActionResult (or a class derived from ActionResult), not a type like string.


        // https://localhost:5001 An HTTP endpoint is a targetable URL in the web application
        // GET: /HelloWorld/Welcome/ 

        // Requires add using System.Text.Encodings.Web;

        /*public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is :{numTimes}");
            //Uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript).
        }*/
        //Run the app and browse to:http://localhost:61707/HelloWorld/Welcome?name=lijing&numtimes=666  The & character separates query strings.
        // the output is "Hello lijing, NumTimes is :666"  ,the name and numTimes parameters are passed as query strings.
        //In the  above, the URL segment (Parameters) isn't used.The ?  in the above URL is a separator, and the query strings follow. 

        /*public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }*/


        //Run the app and enter the following URL: http://localhost:61707/HelloWorld/Welcome/3?name=Rick
        //This time the third URL segment matched the route parameter id.--- The output is "Hello Rick, ID: 3"
        //The NEW Welcome method contains a parameter id that matched the URL template in the MapRoute method.
        //                                         The trailing ? (in id?) indicates the id parameter is optional.

        //In these examples the controller has been doing the "VC" portion of MVC - that is, the view and controller work.
        //The controller is returning HTML directly. 


        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            //The ViewData dictionary object contains data that will be passed to the view.
            //The ViewData dictionary is a dynamic object, which means any type can be used;
            //the ViewData object has no defined properties until you put something inside it. 
            return View();
        }
    }

}