using System.Web;
using System.Web.Mvc;

namespace FatecRP.EmpreendeRP.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
