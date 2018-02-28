﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aiursoft.Colossus.Models;
using Aiursoft.Pylon.Attributes;
using System.IO;

namespace Aiursoft.Colossus.Controllers
{
    [AiurRequireHttps]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            var file = Request.Form.Files.First();
            await Pylon.Services.StorageService.SaveToOSS(file,Startup.ColossusPublicBucketId);
            return Json(new
            {
                size = file.Length
            });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
