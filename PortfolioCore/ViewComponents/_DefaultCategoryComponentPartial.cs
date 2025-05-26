using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultCategoryComponentPartial:ViewComponent
    {
        PortfolioContext db = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = db.Categories.ToList();
            return View(values);
        }

    }
}
