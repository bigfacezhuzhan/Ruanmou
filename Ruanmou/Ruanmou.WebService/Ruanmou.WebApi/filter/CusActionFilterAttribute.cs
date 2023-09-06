using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Ruanmou.WebApi.filter
{
	public class CusActionFilterAttribute:ActionFilterAttribute
	{
		public override void OnActionExecuting(HttpActionContext actionContext)
		{
			base.OnActionExecuting(actionContext);
		}
		public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
		{
			actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:1224");
			actionExecutedContext.Response.Headers.Add("zhuzhan", "*");
		}
	}
}