using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Security;

namespace Ruanmou.WebApi.filter
{
	/// <summary>
	/// Basic验证
	/// </summary>
	public class BasicAuthorizeFilterAttribute:AuthorizeAttribute
	{
		/// <summary>
		/// 发生请求前去验证
		/// </summary>
		/// <param name="actionContext"></param>
		public override void OnAuthorization(HttpActionContext actionContext)
		{
			var authorization = actionContext.Request.Headers.Authorization;
			if (actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>(true).Count != 0 || actionContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>(true).Count != 0)
			{
				base.OnAuthorization(actionContext);
			}
			else if (authorization != null && authorization.Parameter != null)
			{
				if (authorization.Parameter!="undefined"&&ValidateTicket(authorization.Parameter))
				{
					base.IsAuthorized(actionContext);
				}
				else
				{
					this.HandleUnauthorizedRequest(actionContext);
				}
			}
			else
			{
				this.HandleUnauthorizedRequest(actionContext);
			}
		}
	
		private bool ValidateTicket(string encryptTicket)
		{
			string strTicket= FormsAuthentication.Decrypt(encryptTicket).UserData;
			//检查过期时间
			//...

			return string.Equals(strTicket, $"admin&123");
		}

		protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
		{
			var cg= new HttpResponseMessage(HttpStatusCode.Unauthorized);
			cg.Headers.Add("WWW-Authenticate", "Basic");
			base.HandleUnauthorizedRequest(actionContext);//返回没有授权
		}
	}
}