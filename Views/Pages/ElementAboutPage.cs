using ElementDemo.Views.Modules;
using MOD.Web.Element;
using MOD.Web.Element.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Pages
{
	public class ElementAboutPage : Page
	{
		public override MOD.Web.Element.Node Render()
		{
			return Container.Add(
				new PageHeaderModule(),
				Element.Create("div#main").Add(
					Element.Create("h2").Add("About"),
					Element.Create("p").Add("Put content here.")
				),
				RenderFooter()
			);
		}
	}
}