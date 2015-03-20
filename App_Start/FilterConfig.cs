using System.Web;
using System.Web.Mvc;

namespace Hera.App_Start
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
      filters.Add(new AuthorizeAttribute());
      filters.Add(new RequireHttpsAttribute());
    }
  }
}