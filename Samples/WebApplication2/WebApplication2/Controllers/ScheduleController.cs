using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Schedule
        public ActionResult Index()
        {
            using (var httpClient = new HttpClient())
            {
                string json = httpClient.GetStringAsync("http://ufdemo.azurewebsites.net/schedule").Result;


                List<ScheduleItem> schedule = JsonConvert.DeserializeObject<List<ScheduleItem>>(json);

                return View(schedule);
            }

        }
    }
}