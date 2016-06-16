using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Euro2016.Helpers
{
    public static class CustomHtmlHelpers
    {
        public static IHtmlString ImageActionLink(this HtmlHelper htmlHelper,
        string linkText, string action, string controller,
        object routeValues, object htmlAttributes, string imageSrc)
        {
            var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);
            var img = new TagBuilder("img");
            img.Attributes.Add("src", VirtualPathUtility.ToAbsolute(imageSrc));
            var anchor = new TagBuilder("a") { InnerHtml = img.ToString(TagRenderMode.SelfClosing) };
            anchor.Attributes["href"] = urlHelper.Action(action, controller, routeValues);
            anchor.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            return MvcHtmlString.Create(anchor.ToString());
        }
    }

    public static class ImageHelper
    {
        public static MvcHtmlString Image(this HtmlHelper helper, String src, String height)
        {
            var builder = new TagBuilder("img");
            builder.MergeAttribute("src", src);
            builder.MergeAttribute("alt", src);
            builder.MergeAttribute("height", height);
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }

    }
}

