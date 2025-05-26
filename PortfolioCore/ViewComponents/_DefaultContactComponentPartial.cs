using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{

    public class _DefaultContactComponentPartial:ViewComponent
    {
        PortfolioContext Context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var contact = Context.Contacts.ToList();
            return View(contact);
        }
    }
}

