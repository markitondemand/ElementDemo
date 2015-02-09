using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElementDemo.Views.Shared
{
	public class ElementActionResult : ActionResult
	{
		public ElementActionResult(INode node)
		{
			content = node;
		}
		private INode content;

		public override void ExecuteResult(ControllerContext context)
		{
			content.Write(context.HttpContext.Response.Output);
		}
	}
}