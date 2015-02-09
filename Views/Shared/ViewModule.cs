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
	public class ViewModule : IRenderable, IHtmlString
	{
		/// <summary>
		/// 
		/// </summary>
		protected IElement _Container = null;

		/// <summary>
		/// The Element that represents markup for the module.
		/// </summary>
		protected IElement Container
		{
			get { return _Container = _Container ?? CreateContainer(); }
			set { _Container = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public virtual INode Render() { return Container; }

		/// <summary>
		/// Implement this method to override control the Container Element that is created for each instance
		/// </summary>
		/// <returns>Container Element</returns>
		protected virtual IElement CreateContainer()
		{
			return Element.Create("div");
		}

		public string ToHtmlString()
		{
			return Render().ToString();
		}
	}
}