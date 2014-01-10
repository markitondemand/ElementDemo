using ElementDemo.Views;
using ElementDemo.Views.Modules;
using ElementDemo.Views.Pages;
using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElementDemo.Controllers
{
	public class HomeController : ElementBaseController
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Welcome to ASP.NET MVC!";

			return View();
		}

		public ActionResult About()
		{
			return View();
		}
		public ActionResult ElementIndex()
		{
			var doc = new DefaultDocument
			{
				PageView = new ElementHomePage(),
				Title = "Home Page"
			};
			return Content(doc);
		}
		public ActionResult ElementAbout()
		{
			var doc = new DefaultDocument
			{
				PageView = new ElementAboutPage(),
				Title = "About Us"
			};
			return Content(doc);
		}
	}
}
