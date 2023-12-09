using Microsoft.AspNetCore.Mvc;
using S2P1.Data;
using S2P1.Interfaces;
using S2P1.Models;
using System.Diagnostics;
using static NuGet.Packaging.PackagingConstants;
//Group Assignmnent :   S2P2
//Student numbers   :221004954;219014233;222006734;220003789
//Purpose:          :The purpose of this program is to provide the user with a web based page of the people stored in the database and display their information details.


namespace S2P1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SQLiteDBContext _context;
        private readonly IDBInitializer _seedDatabase;


        public HomeController(ILogger<HomeController> logger, SQLiteDBContext context,IDBInitializer seedDatabase)
        {
            _logger = logger;
            _context = context;
            _seedDatabase = seedDatabase;
        }

        public IActionResult SeedDatabase()
        {
            //Name:     IActionResult SeedDatabase
            //Purpose:  Return the populated database view of the user

            //Reuse:    Reusable
            //Input:    None

            //Output:   Ouputs a View of SeedDatabase

            _seedDatabase.Initialize(_context);
            ViewBag.SeedDbFeedback = "Database created and Person and PersonAddress Table populated with Data.Check Database folder.";
            return View("SeedDatabase");
        }


        public IActionResult Index()
        {
            //Name:     IActionResult Index
            //Purpose:  Return Default view of Index to the user

            //Reuse:    Reusable
            //Input:    None

            //Output:   Ouputs a View of Index
            return View();
        }

        public IActionResult Privacy()
        {
            //Name:     IActionResult Privacy
            //Purpose:  Return view of Privacy to the user

            //Reuse:    Reusable
            //Input:    None

            //Output:   Ouputs a View of Privacy
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //Name:     IActionResult Error
            //Purpose:  Return Error View to the user when an error has occured

            //Reuse:    Reusable
            //Input:    None

            //Output:   Ouputs a View of Error
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}