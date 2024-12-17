using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
	public class LayoutController : Controller
	{
        [Authorize(Roles = "Admin")]

        public IActionResult Index()
		{
			return View();
		}
	}
}
