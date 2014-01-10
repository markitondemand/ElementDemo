using MOD.Web.Element;
using MOD.Web.Element.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Modules
{
	public class PageHeaderModule : ViewModule
	{
		public override MOD.Web.Element.Node Render()
		{
			return Container.Add(
				RenderTitle(),
				RenderLogin(),
				new MainNavigationModule()
			).SetAttribute("id", "header");
		}
		protected Element RenderTitle()
		{
			return Element.Create("div#title").Add(
				Element.Create("h1").Add("My Element/ MVC Application")
			);
		}
		protected Element RenderLogin()
		{
			return Element.Create("div#logindisplay").Add(
				"[ ",
				Element.Create("a", "href", "~/Account/LogOn").Add("Log On"),
				" ]"
			);
		}
	}
}