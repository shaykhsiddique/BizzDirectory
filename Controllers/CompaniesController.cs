using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BizzDirectory.Controllers{
    public class CompaniesController : Controller{
        public IActionResult Index()
        {
            return View();
        }
    }
}