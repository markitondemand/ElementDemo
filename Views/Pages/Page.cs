using ElementDemo.Views.Shared;
using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Pages
{
	public abstract class Page : ViewModule
	{
		protected override IElement CreateContainer()
		{
			return base.CreateContainer().AddClass("page");
		}
		protected IElement RenderFooter()
		{
			return Element.Create("div#footer");
		}
	}
}