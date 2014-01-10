using MOD.Web.Element;
using MOD.Web.Element.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Modules
{
	public class ExampleModule : ViewModule
	{
		public override MOD.Web.Element.Node Render()
		{
			return Container.Add(
				Element.Create("h2").Add("Welcome to ASP.NET MVC with Element!"),
				RenderInfo()
			).SetAttribute("id", "main");
		}
		protected Element RenderInfo()
		{
			return Element.Create("p").Add(
				"To learn more about ASP.NET MVC visit ",
				Element.Create("a", "href", "http://asp.net/mvc").Add("http://asp.net/mvc")
			);
		}

	}
}