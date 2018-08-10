using System.Web;
using System.Web.Mvc;

namespace Legal_Business_Content_Survey_Site
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
