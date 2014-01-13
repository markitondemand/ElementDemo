# ElementDemo

This is a small demo project using [MOD.Web.Element](https://github.com/markitondemand/MOD.Web.Element). It recreates several pages from the Visual Studio ASP.Net MVC Web
Application template. The intention of the project is to give a few simple examples of how to render HTML content in a C# MVC web application using  [MOD.Web.Element](https://github.com/markitondemand/MOD.Web.Element)
rather than Razor or other templating languages. 

## Key Take-aways

There are a few important items to take note of in this project if you are looking to start
a new MVC .Net project using Element. These are suggested steps to creating a web application
using Element.

### Create a Document Class that Inherits HtmlDocument.cs

*HtmlDocument.cs* acts as a light-weight wrapper around the html document node and contains
members for the items we might expect an html document to have (Head, Body, Title, etc). These classes
perform roughly the same role as  *_Layout.cshtml* files do in the Razor approach. 
In our application, we can create one or more classes that inherit from this class to control
any special logic around what gets added to the various components of our document. For example, we may eventually
want to plug in control for bundles  (javascript and css). In the example provided, we are just overriding the
*Render* method in *DefaultDocument.cs* to add the Title element to the Head, as well as a style sheet, along with adding
the 'PageView' element to the Body.

### Create a base controller class 

You will note in the controllers directory, we have created a class called *ElementBaseController.cs*. This class
is an abstract class from which we'll derive our other controller classes from rather than
directly deriving from *Controller*. Here, we've overloaded the *Content* method to accept
an *IRenderable* which is an interface that *Element* objects implement. This creates a level of 
convenience and consistency in our approach to dealing with *Element* objects within our controllers.
For ActionResults, we want to be returning the content of an html document, so this overload allows us to pass
an *Element* representing the html document while taking care of writing out the doctype to go with the content.

```csharp
public abstract class ElementBaseController : Controller
	{
		public const string HTML_DOCTYPE = @"<!DOCTYPE html>";
		/// <summary>
		/// Will render an IRenderable object which should represent the html node of a web page
		/// </summary>
		/// <param name="htmlElement">The html node of a web page</param>
		/// <returns>The content result including the doctype</returns>
		public ActionResult Content(IRenderable htmlElement)
		{
			Response.Write(HTML_DOCTYPE);
			return Content(htmlElement.Render().ToString());
		}
	}
```
### Create Modules

Like classes that inherit from *HtmlDocument.cs*, modules are classes that act as wrappers for 
a discrete piece of content (think partial view). Although we could create an entire page worth
of content within an indiviaul .cs file, we perfer breaking up a page into logical divisions
of content for the sake of flexibility, reusability and maintainability. Module classes inherit
from MOD.Web.Element.Module.ViewModule, and overwrite the *Render* method to determine what content
is created when the module is invoked. 

```csharp
public class PageHeaderModule : ViewModule
{
	public override MOD.Web.Element.Node Render()
	{
		return Container.Add(
			RenderTitle(),
			RenderLogin(),
			new MainNavigationModule()
		).SetAttribute("id", "header");
	}
	protected Element RenderTitle()
	{
		return Element.Create("div#title").Add(
			Element.Create("h1").Add("My Element/ MVC Application")
		);
	}
	protected Element RenderLogin()
	{
		return Element.Create("div#logindisplay").Add(
			"[ ",
			Element.Create("a", "href", "~/Account/LogOn").Add("Log On"),
			" ]"
		);
	}
}
```

One exciting feature of *ViewModule* classes is that they can be added to Element structures
just as Element's can. You will notice in the example above that we are adding a new instance
of *MainNavigationModule* directly to the *PageHeaderModule*'s container element. In this approach,
Views generally comprise of a large set of, sometimes deeply nested modules. 