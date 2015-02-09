using ElementDemo.Views.Shared;
using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElementDemo.Controllers
{
	public abstract class ElementBaseController : Controller
	{
		public const string HTML_DOCTYPE = @"<!DOCTYPE html>";
		/// <summary>
		/// Will render an IRenderable object which should represent the html node of a web page
		/// </summary>
		/// <param name="htmlElement">The html node of a web page</param>
		/// <returns>The content result including the doctype</returns>
		public ActionResult Content(IRenderable htmlElement)
		{
			var page = Element.Fragment().Add(
				Element.Html(HTML_DOCTYPE)
				,htmlElement.Render()
			);
			return new ElementActionResult(page);
		}
	}
}