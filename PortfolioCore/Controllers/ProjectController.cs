using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ProjectController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ProjectList()
        {
            var values = context.Projects.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProject(Project Project)
        {
            context.Projects.Add(Project);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        public IActionResult DeleteProject(int id)
        {
            var value = context.Projects.Find(id);
            context.Projects.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            var value = context.Projects.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProject(Project Project)
        {
            context.Projects.Update(Project);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
    }
}
