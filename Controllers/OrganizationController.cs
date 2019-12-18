using System.Linq;
using BizzDirectory.Data;
using BizzDirectory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BizzDirectory.Controllers
{
    public class OrganizationController : Controller
    {
        private const int PageSize = 10;

        protected DbSet<Organization> Organizations;

        public OrganizationController(CommonContext context) =>
            Organizations = context.Set<Organization>();

        [HttpGet("Browse/{pageNo}")]
        public IActionResult Browse(int? categoryId, int pageNo = 1, string keywords = null)
        {
            var firstIndex = (pageNo - 1) * PageSize;
            var organizations = Organizations.Skip(firstIndex).Take(PageSize);
            return View(organizations);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(Organization organization)
        {
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Read(int id)
        {
            var organization = Organizations.FirstOrDefault(o => o.Id == id);
            if (organization == null) return NotFound();
            return View(organization);
        }

        [HttpGet("Update/{id}")]
        public IActionResult Update(int id)
        {
            return View();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Organization organization)
        {
            return View();
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            return View();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, bool accepted)
        {
            return View();
        }

    }
}
