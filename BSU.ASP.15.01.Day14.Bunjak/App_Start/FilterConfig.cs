using System.Web;
using System.Web.Mvc;

namespace BSU.ASP._15._01.Day14.Bunjak
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
