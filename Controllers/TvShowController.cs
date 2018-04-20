using System;
using Microsoft.AspNetCore.Mvc;

namespace tvsnotification.api
{
    [Route("api/[Controller]")]
    public class TvShowController : Controller
    {
        public IActionResult GetMyTvShows()
        {
            return Ok("Controller implementation in progress");
        }
    }
}