using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
		MyPortfolioContext context = new MyPortfolioContext();

		public IViewComponentResult Invoke()
        {
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v6 = context.Portfolios.Count();

			return View();
        }
    }
}
