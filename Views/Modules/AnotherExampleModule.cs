using ElementDemo.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MOD.Web.Element;

namespace ElementDemo.Views.Modules
{
	public class AnotherExampleModule : ViewModule
	{
		public AnotherExampleModule(bool linkToElement = false)
		{
			this.linkToElement = linkToElement;
		}
		private bool linkToElement;

		public override INode Render()
		{
			string link = linkToElement
				? "~/Home/ElementIndex".ResolvePath()
				: "~/Home".ResolvePath()
			;
 			return Container.Add(
				Element.Create("hr"),
				Element.Text("Click "),
				Element.Create("a","href",link).AddText("here"),
				Element.Text(" to see the "+(linkToElement?"Element":"Razor")+" version")
			);
		}
	}
}