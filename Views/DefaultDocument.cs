using ElementDemo.Views.Shared;
using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views
{
	public class DefaultDocument : HtmlDocument
	{
		public override MOD.Web.Element.INode Render()
		{
			Body.Add(PageView.Render());

			Head.Add(
				Element.Create("link", "rel", "stylesheet", "type", "text/css", "href", "~/Content/Site.css".ResolvePath())
			);

			Head.Add(
				Element.Create("title").Add(Title)
			);

			return Container;
		}
	}
}