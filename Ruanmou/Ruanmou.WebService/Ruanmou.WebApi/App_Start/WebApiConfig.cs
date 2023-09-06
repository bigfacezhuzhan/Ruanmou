using Ruanmou.WebApi.filter;
using Ruanmou.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.ExceptionHandling;
using System.Web.Mvc;

namespace Ruanmou.WebApi
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API 配置和服务
			config.Filters.Add(new CusExceptionFilterAttribute());//只对WebApi的接口生效
																  // Web API 路由
			config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
			config.DependencyResolver = new UnityDependencyResolver(ContainerFactory.CreateContainer());
			config.MapHttpAttributeRoutes();

			//配置跨域请求 
			//config.EnableCors(new EnableCorsAttribute("*", "*", "*"));//允许任意请求
			EnableCorsAttribute cors = new EnableCorsAttribute("http://localhost:1224", "*", "*");
			//cors.Origins.Add("http://localhost:1224");
			config.EnableCors(cors);
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			config.Routes.MapHttpRoute(
				name: "usertApi",
				routeTemplate: "userapi/{controller}/{action}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
