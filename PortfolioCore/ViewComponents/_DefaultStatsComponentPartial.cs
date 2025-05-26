using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatsComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.referenceCount = context.Testimonials.Count();
            ViewBag.projectCount = context.Projects.Count();
            ViewBag.skillCount = context.Skills.Count();
            Random random = new Random();
            int randomNumber = random.Next(10, 21);
            ViewBag.randomnumber= randomNumber;
            return View();
        }
    }
}
