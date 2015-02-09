using MOD.Web.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo.Views.Shared
{
	/// <summary>
	/// This interface can be used by any class/object that can be rendered
	/// to a Node.  Element itself knows to call this function on an 
	/// instance if it implements this interface.
	/// </summary>
	public interface IRenderable
	{
		/// <summary>
		/// This interface can be used by any class/object that can be rendered
		/// to a Node.  Element itself knows to call this function on an 
		/// instance if it implements this interface.
		/// </summary>
		/// <returns>An instance of Node</returns>
		INode Render();
	}
}