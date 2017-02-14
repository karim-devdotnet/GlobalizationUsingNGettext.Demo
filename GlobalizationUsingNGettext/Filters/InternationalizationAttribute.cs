using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace GlobalizationUsingNGettext.Filters
{
    public class InternationalizationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            string language = (string)filterContext.RouteData.Values["language"] ?? "de";
            string culture = (string)filterContext.RouteData.Values["culture"] ?? "DE";

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo($"{language}-{culture}");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo($"{language}-{culture}");

        }
    }
}