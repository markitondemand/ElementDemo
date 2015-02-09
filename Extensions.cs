using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementDemo
{
	public static class Extensions
	{
		public static string ResolvePath(this string path)
		{
			if (path != null && path.StartsWith("~/")) {
				return VirtualPathUtility.ToAbsolute(path);
			}
			return path;
		}
	}
}