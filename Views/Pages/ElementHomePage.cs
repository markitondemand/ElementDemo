using ElementDemo.Views.Modules;
using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Pages
{
	public class ElementHomePage : Page
	{
		public override MOD.Web.Element.INode Render()
		{
			return Container.Add(
				new PageHeaderModule().Render(),
				new ExampleModule().Render(),
				RenderFooter()
			);
		}
		
	}
}