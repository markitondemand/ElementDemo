using MOD.Web.Element;
using MOD.Web.Element.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Pages
{
	public abstract class Page : ViewModule
	{
		protected override Element CreateContainer()
		{
			return base.CreateContainer().AddClass("page");
		}
		protected Element RenderFooter()
		{
			return Element.Create("div#footer");
		}
	}
}