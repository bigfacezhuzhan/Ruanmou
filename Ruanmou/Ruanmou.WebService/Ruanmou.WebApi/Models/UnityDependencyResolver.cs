using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Unity;

namespace Ruanmou.WebApi.Models
{
	public class UnityDependencyResolver : IDependencyResolver
	{
		private IUnityContainer UnityContainer = null;
		public UnityDependencyResolver(IUnityContainer unityContainer)
		{
			this.UnityContainer = unityContainer;
		}
		public IDependencyScope BeginScope()
		{
			IUnityContainer child= this.UnityContainer.CreateChildContainer();
			return new UnityDependencyResolver(child);
		}

		public void Dispose()
		{
			this.UnityContainer.Dispose();
		}
		/// <summary>
		/// 获取单个服务
		/// </summary>
		/// <param name="serviceType"></param>
		/// <returns></returns>
		public object GetService(Type serviceType)
		{
			try
			{
				return this.UnityContainer.Resolve(serviceType);
			}
			catch (ResolutionFailedException ex)
			{
				return null;
			}
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			try
			{
				return this.UnityContainer.ResolveAll(serviceType);
			}
			catch (ResolutionFailedException ex)
			{
				return new List<object>();
			}
		}
	}
}