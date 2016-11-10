using System.Web;
using System.Web.Mvc;

namespace comp229_f2016_lesson9_mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
