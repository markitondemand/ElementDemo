using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Shared
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class HtmlDocument : ViewModule
	{
		/// <summary>
		/// 
		/// </summary>
		public virtual IElement Body { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public virtual IElement Head { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public virtual string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public virtual string Language { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public virtual string Charset { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public virtual IRenderable PageView { get; set; }

		/// <summary>
		/// Setups the parts of a default page.
		/// </summary>
		public HtmlDocument()
		{
			Container = Element.Create("html");
			Head = Element.Create("head");
			Body = Element.Create("body");

			Container.Add(Head, Body);
		}
	}
}