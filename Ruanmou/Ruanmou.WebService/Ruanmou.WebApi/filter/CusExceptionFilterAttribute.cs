using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
namespace Ruanmou.WebApi.filter
{
	public class CusExceptionFilterAttribute: ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext actionExecutedContext)
		{
			string url= actionExecutedContext.ActionContext.Request.RequestUri.AbsoluteUri;
			actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(
				HttpStatusCode.OK, new { result = false, message = "出问题啦！请联系朱展" });
		}
	}
}