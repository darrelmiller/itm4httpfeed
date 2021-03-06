﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace feedApi.Controllers
{
    [Route("")]
    [Route("feed")]
    public class FeedController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            FileStreamResult result;
            var stream = this.GetType().Assembly.GetManifestResourceStream("feedApi.feed.xml");
            result =  new FileStreamResult(stream, "application/xml");
            return result;
        }
    }
}
