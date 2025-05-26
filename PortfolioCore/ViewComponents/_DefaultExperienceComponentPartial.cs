using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultExperienceComponentPartial:ViewComponent
    {
        PortfolioContext db = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = db.Experiences.ToList();
            return View(value);
        }
    }
}
