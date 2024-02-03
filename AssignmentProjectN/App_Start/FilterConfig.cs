using System.Web;
using System.Web.Mvc;

namespace AssignmentProjectN01617698
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
