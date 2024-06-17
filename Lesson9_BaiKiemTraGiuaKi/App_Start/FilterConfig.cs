using System.Web;
using System.Web.Mvc;

namespace Lesson9_BaiKiemTraGiuaKi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
