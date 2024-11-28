using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentsPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
