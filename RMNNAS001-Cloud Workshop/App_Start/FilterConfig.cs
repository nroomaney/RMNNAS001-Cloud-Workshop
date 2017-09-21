using System.Web;
using System.Web.Mvc;

namespace RMNNAS001_Cloud_Workshop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
