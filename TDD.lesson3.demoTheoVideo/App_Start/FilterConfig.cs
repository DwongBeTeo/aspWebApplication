using System.Web;
using System.Web.Mvc;

namespace TDD.lesson3.demoTheoVideo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
