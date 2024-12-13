using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();    
        public IActionResult MediaList()
        {
            var value=context.SocialMedias.ToList();
            return View(value);
        }
    }
}
