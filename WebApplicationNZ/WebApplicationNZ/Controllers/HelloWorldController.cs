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

        public string Index()
        {
            return "lijing This is my default action...";
        }

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
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
        //Run the app and enter the following URL: http://localhost:61707/HelloWorld/Welcome/3?name=Rick
        //This time the third URL segment matched the route parameter id.--- The output is "Hello Rick, ID: 3"
        //The NEW Welcome method contains a parameter id that matched the URL template in the MapRoute method.
        //                                         The trailing ? (in id?) indicates the id parameter is optional.
    }

}