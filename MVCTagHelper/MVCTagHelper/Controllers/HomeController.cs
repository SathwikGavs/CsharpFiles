using Microsoft.AspNetCore.Mvc;
using MVCTagHelper.Models;
using System.Diagnostics;
using System.Text;

namespace MVCTagHelper.Controllers
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

        [HttpPost]
        public IActionResult Index(int x, IFormCollection collection)
        {
            StringBuilder data= new StringBuilder(500);
            data.Append("x:");
            data.Append(x);
            data.Append("");
            data.Append("name:");
            data.Append(collection["name"]);
            data.Append(" ");
            data.Append("password:");
            //foreach (var item in collection)
            //{
            //    data.Append(item.Key);
            //    data.Append(";");
            //    data.Append(item.Value);
            //    data.Append(" ");
            //}
            ViewData["x"] = data.ToString();
            return View("IndexPost");
        }
        public IActionResult DoTask(int? id) 
        {
            if(id.HasValue)
            {
                ViewData["id"]= id.Value;

            }
            else 
            {
                ViewData["id"] = id.Value;
            }
            return View();
        
        }
        public IActionResult Test()
        {
            return RedirectToAction("Index");
        }
        public IActionResult GetBook()
        {
            Book b1 = new Book() { AuthorName = "H Lee"};
            ViewData["book"] = b1;
            return View();

        }
        public IActionResult Privacy()
        {
            return View();
        }
		public IActionResult Menu()
		{
            _logger.Log(LogLevel.Information, "Testing");
			return View();
		}

		public ActionResult Echo(String name, String city)
		{
			String s1 = "user " + name + " from city" + city;
			ViewData.Add("Data1", s1);
			return View();
		}
		public ActionResult SayHello(String name)
        {
            //Home/SayHello?name=Sathwik
            String s1 = ("Hello " + name);
            ViewData.Add("Data1", s1);
            return View("Echo");
        }


		[ResponseCache(Duration =15)]
        public IActionResult GetTime()
        {
            String todata = DateTime.Now.ToLongTimeString();
            ViewData["data"]=todata;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

