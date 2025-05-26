using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial : ViewComponent
    {
        PortfolioContext Context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = Context.SocialMedias.ToList();
            return View(values);
        }
    }
}
