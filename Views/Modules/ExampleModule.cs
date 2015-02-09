using ElementDemo.Views.Shared;
using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Modules
{
	public class ExampleModule : ViewModule
	{
		public override MOD.Web.Element.INode Render()
		{
			return Container.Add(
				Element.Create("h2").Add("Welcome to ASP.NET MVC with Element!"),
				RenderInfo()
			).SetAttribute("id", "main");
		}
		protected IElement RenderInfo()
		{
			return Element.Create("p").Add(
				Element.Text("To learn more about ASP.NET MVC visit "),
				Element.Create("a", "href", "http://asp.net/mvc").Add("http://asp.net/mvc"),
				new ElementDemo.Views.Modules.AnotherExampleModule().Render()
			);
		}

	}
}