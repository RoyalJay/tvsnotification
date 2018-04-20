using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tvsnotification.api
{
  [Route("api/[Controller]")]
  public class TvShowController : Controller
  {
    [HttpGet]
    public IActionResult GetMyTvShows()
    {
      var text = string.Empty;
      var url = "https://api.themoviedb.org/3/tv/latest?api_key=9b478458aeab42d982a631cf6c7157dc";
      var webRequest = (HttpWebRequest) WebRequest.Create(url);
      webRequest.Method = WebRequestMethods.Http.Get;
      webRequest.Accept = "application/json";

      var response = (HttpWebResponse) webRequest.GetResponse();

      using (var sr = new StreamReader(response.GetResponseStream()))
      {
        text = sr.ReadToEnd();
        return Json(text);
      }
    }
  }
}
