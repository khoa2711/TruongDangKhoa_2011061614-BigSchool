using System.Web;
using System.Web.Mvc;

namespace TruongDangKhoa_2011061614
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
