using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        // public string Index()
        // {
        //     return "This is my default action... Hello Shaykh";
        // }
        public IActionResult Index(){
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        // public string Welcome()
        // {
        //     return "This is the Welcome action method...";
        // }

        // pass referance style -- https://localhost:5001/helloworld/welcome?name=shaykh&numtimes=7
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        // pass referance style -- localhost:5001/helloworld/welcomesec/3?name=Shaykh
        public string Welcomesec(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}