using ElementDemo.Views.Shared;
using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Modules
{
	public class MainNavigationModule : ViewModule
	{
		public override MOD.Web.Element.INode Render()
		{
			return Container.Add(
				Element.Create("ul#menu").Add(
					Element.Create("li").Add(
						Element.Create("a", "href", "~/Home/ElementIndex".ResolvePath()).Add("Home")
					),
					Element.Text(" "),//the template relies on spaces to provide space between the li's - bad practice but want to make this as direct a replica as possible
					Element.Create("li").Add(
						Element.Create("a", "href", "~/Home/ElementAbout".ResolvePath()).Add("About")
					)
				)
			).SetAttribute("id", "menucontainer");
		}
	}
}