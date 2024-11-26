using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Models.ViewComponents
{
    public class _HeadComponenetPartial:ViewComponent 
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
