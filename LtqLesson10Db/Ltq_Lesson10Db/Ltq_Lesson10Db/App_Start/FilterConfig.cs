using System.Web;
using System.Web.Mvc;

namespace Ltq_Lesson10Db
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
