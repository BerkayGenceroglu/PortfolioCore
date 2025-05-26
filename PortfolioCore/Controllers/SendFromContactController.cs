using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SendFromContactController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
            TempData["MessageSent"] = true;
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
