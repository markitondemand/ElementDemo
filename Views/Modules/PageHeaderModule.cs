using ElementDemo.Views.Shared;
using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Modules
{
	public class PageHeaderModule : ViewModule
	{
		public override MOD.Web.Element.INode Render()
		{
			return Container.Add(
				RenderTitle(),
				RenderLogin(),
				new MainNavigationModule().Render()
			).SetAttribute("id", "header");
		}
		protected IElement RenderTitle()
		{
			return Element.Create("div#title").Add(
				Element.Create("h1").Add("My Element/ MVC Application")
			);
		}
		protected IElement RenderLogin()
		{
			return Element.Create("div#logindisplay").Add(
				Element.Text("[ "),
				Element.Create("a", "href", "~/Account/LogOn".ResolvePath()).Add("Log On"),
				Element.Text(" ]")
			);
		}
	}
}