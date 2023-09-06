using Ruanmou.WebApi.filter;
using System.Web;
using System.Web.Mvc;

namespace Ruanmou.WebApi
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
