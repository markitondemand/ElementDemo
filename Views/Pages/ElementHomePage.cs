using ElementDemo.Views.Modules;
using MOD.Web.Element;
using MOD.Web.Element.Module;
using MOD.Web.Element.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Pages
{
	public class ElementHomePage : Page
	{
		public override MOD.Web.Element.Node Render()
		{
			return Container.Add(
				new PageHeaderModule(),
				new ExampleModule(),
				RenderFooter()
			);
		}
		
	}
}