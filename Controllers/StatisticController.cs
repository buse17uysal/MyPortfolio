using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    [Authorize(Roles = "Admin")]

    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x=>x.IsRead==false).Count();
            ViewBag.v4 = context.Messages.Where(x=>x.IsRead==true).Count();
            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6 = context.Portfolios.Count();
            ViewBag.v7 = context.SocialMedias.Count();
            ViewBag.v8 = context.ToDoLists.Count();
            ViewBag.v9 = context.ToDoLists.Where(x=>x.Status==false).Count();
            ViewBag.v10 = context.ToDoLists.Where(x=>x.Status==true).Count();
            return View();
        }
    }
}
