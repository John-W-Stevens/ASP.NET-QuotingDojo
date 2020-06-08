using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using DbConnection;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult CreateQuote(Quote newQuote)
        {
            
            if (ModelState.IsValid)
            {
                string query = $"INSERT INTO quotes (username, quote, created_at, updated_at) VALUES ('{newQuote.username}', '{newQuote.quote}', NOW(), NOW())";
                DbConnector.Execute(query);
            }
            else
            {
                return View("Index");
            }

            return RedirectToAction("DisplayQuotes");
        }

        [HttpGet("quotes")]
        public IActionResult DisplayQuotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quotes");
            // To provide this data, we could use ViewBag or a View Model.  ViewBag shown here:
            ViewBag.Quotes = AllQuotes;

            return View();
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
}
