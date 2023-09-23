using Microsoft.AspNetCore.Mvc;

namespace MVCTagHelper.Controllers
{
	public class DeadpoolController : Controller
	{
		public IActionResult Start()
		{
			return View();
		}
	}
}
