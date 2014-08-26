using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace UFData.Web
{
    public class ScheduleController : Controller
    {
        public ScheduleController()
        {
        }
        public async Task<IActionResult> Get()
        {
            var schedule = new ScheduleData().GetSchedule();

            return Json(schedule);
        }
    }

}