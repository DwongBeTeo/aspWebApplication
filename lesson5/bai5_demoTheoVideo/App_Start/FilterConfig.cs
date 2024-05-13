using System.Web;
using System.Web.Mvc;

namespace bai5_demoTheoVideo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
