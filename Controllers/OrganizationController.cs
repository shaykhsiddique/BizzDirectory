using Microsoft.AspNetCore.Mvc;

namespace BizzDirectory.Controllers
{
    public class OrganizationController : Controller
    {
        [HttpGet("Browse/{pageNo}")]
        public IActionResult Browse(int? pageNo, int? categoryId, string keywords = null)
        {
            return View();
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(bool _)
        {
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Read()
        {
            return View();
        }

        [HttpGet("Update/{id}")]
        public IActionResult Update(int id)
        {
            return View();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, bool _)
        {
            return View();
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            return View();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, bool _)
        {
            return View();
        }

    }
}
