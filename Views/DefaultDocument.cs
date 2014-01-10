using MOD.Web.Element;
using MOD.Web.Element.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views
{
	public class DefaultDocument : HtmlDocument
	{
		public override MOD.Web.Element.Node Render()
		{
			Body.Add(PageView);

			Head.Add(
				Element.Create("link", "rel", "stylesheet", "type", "text/css", "href", "~/Content/Site.css")
			);

			Head.Add(
				Element.Create("title").Add(Title)
			);

			return Container;
		}
	}
}