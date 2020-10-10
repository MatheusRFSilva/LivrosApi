using System.Web;
using System.Web.Mvc;

namespace MSTSolution.LivrosApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
