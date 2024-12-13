using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entites;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();  
        public IActionResult ContactList()
        {
            var value=context.Contacts.ToList();
            return View(value);
        }
        [HttpGet]
        public IActionResult ContactUpdate(int id)
        {
            var value= context.Contacts.Find(id);
            return View(value); 
        
        }
        [HttpPost]
        public IActionResult ContactUpdate(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();  
            return RedirectToAction("ContactList");
        }

    }
}
