using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        PortfolioContext contect = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var about = contect.Abouts.ToList();
            return View(about);
        }
    }
}
