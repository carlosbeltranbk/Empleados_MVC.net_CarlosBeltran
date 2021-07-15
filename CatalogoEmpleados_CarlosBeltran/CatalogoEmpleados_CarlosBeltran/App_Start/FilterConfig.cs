using System.Web;
using System.Web.Mvc;

namespace CatalogoEmpleados_CarlosBeltran
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
