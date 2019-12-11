using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CourceMngr.Controllers{
    public class CompaniesController : Controller{
        public IActionResult Index()
        {
            return View();
        }
    }
}