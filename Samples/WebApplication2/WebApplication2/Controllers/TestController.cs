using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View((object)"");
        }

        [HttpPost]
        public ActionResult Index(string name)
        {

            using (GreetingContext dbContext = new GreetingContext())
            {
                dbContext.Greetings.Add(new Greeting { Name = name });
                dbContext.SaveChanges();
            }
            return View((object)name);
        }

        public ActionResult List()
        {
            List<Greeting> greetings;

            using (GreetingContext dbContext = new GreetingContext())
            {
                greetings = dbContext.Greetings.ToList();
            }

            var viewModel = new ListViewModel(greetings);

            return View(viewModel);
        }
    }
}