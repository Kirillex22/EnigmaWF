using EnigmaServer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EnigmaServer;

namespace EnigmaServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task Encrypt()
        {
            string content = @"<form method='post'>
                <label>Key:</label><br />
                <input name='key' /><br />
                <label>Message:</label><br />
                <input name='message' /><br />
                <input type='submit' value='Send' />
            </form>";
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(content);
        }

        [HttpPost]
        public IActionResult Encrypt(string key, string message)
        {
            App.enigma.Key = key;
            var response = App.enigma.Encrypt(message);
            return Content(response);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public record class Person(string Name, int Age);
}
    