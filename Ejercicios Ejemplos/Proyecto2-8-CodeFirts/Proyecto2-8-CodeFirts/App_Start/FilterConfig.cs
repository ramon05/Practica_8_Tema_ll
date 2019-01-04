using System.Web;
using System.Web.Mvc;

namespace Proyecto2_8_CodeFirts
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
