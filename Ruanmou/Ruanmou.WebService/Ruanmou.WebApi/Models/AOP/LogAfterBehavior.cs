using Ruanmou.WebApi.Models.Log4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace Ruanmou.WebApi.Models.AOP
{
	public class LogAfterBehavior: IInterceptionBehavior
	{
		Log4Factory loger = new Log4Factory(typeof(LogBeforeBehavior));
		public bool WillExecute { get { return true; } }

		public IEnumerable<Type> GetRequiredInterfaces()
		{
			return Type.EmptyTypes;
		}

		public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
		{
			IMethodReturn method = getNext()(input, getNext);
			loger.Info($"{this.GetType().Name}_LogAfterBehavior");
			return method;
		}
	}
}