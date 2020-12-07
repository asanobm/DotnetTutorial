using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMvc.Controllers
{
    /// <summary>
    /// .NET Controller
    /// </summary>
    public class HelloWorldController : Controller
    {
        /// <summary>
        /// GET: https://localhost:5001/HelloWorld
        /// </summary>
        /// <returns>
        /// string message
        /// </returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///    
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="numTimes">
        /// </param>
        /// <returns>
        /// 
        /// </returns>
        // public string Welcome(string name, int numTimes = 1)
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is :{numTimes}");
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}