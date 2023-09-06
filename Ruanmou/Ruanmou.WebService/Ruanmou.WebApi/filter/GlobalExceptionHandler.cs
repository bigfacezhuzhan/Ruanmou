using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace Ruanmou.WebApi.filter
{
	public class GlobalExceptionHandler:ExceptionHandler
	{
		public override bool ShouldHandle(ExceptionHandlerContext context)
		{
			return base.ShouldHandle(context);
		}
		public override void Handle(ExceptionHandlerContext context)
		{
			context.Result = new ResponseMessageResult(context.Request.CreateResponse(
				HttpStatusCode.OK, new {result=false,msg= "url或者控制器实例化错误啦" }
				));
		}
	}
}