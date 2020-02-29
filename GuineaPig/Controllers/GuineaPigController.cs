using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuineaPigData;
using GuineaPig.Models;

namespace GuineaPig.Controllers
{
    public class GuineaPigController : Controller
    {
        [HttpGet]
        public IActionResult DisplayGuineaPigPage()
        {
          GuineaPigInfo data = GuineaPigHandler.getInfo();
            return View("~/Views/Home/GuineaPig.cshtml", data);
        }

        [HttpPost]
        public IActionResult GetGuineaPigData(GuineaPigInfo model)
        {
            GuineaPigInfo data = GuineaPigHandler.getInfo();
            return View("~/Views/Home/GuineaPig.cshtml", data);
        }
    }
}