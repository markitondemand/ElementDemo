using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElementDemo.Controllers
{
	public class ElementBaseController : Controller
	{
		public const string HTML_DOCTYPE = @"<!DOCTYPE html>";

		public ActionResult Content(IRenderable m)
		{
			Response.Write(HTML_DOCTYPE);
			return Content(m.Render().ToString());
		}
	}
}