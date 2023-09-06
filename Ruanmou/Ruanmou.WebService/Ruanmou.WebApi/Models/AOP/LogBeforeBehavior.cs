using Ruanmou.WebApi.Models.Log4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace Ruanmou.WebApi.Models.AOP
{
	public class LogBeforeBehavior : IInterceptionBehavior
	{
		Log4Factory loger = new Log4Factory(typeof(LogBeforeBehavior));
		public bool WillExecute
		{
			get { return true; }
		}
		public IEnumerable<Type> GetRequiredInterfaces()
		{
			return Type.EmptyTypes;
		}

		public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
		{
			//方法执行前的全部动作
			loger.Info($"{this.GetType().Name}_LogBeforeBehavior");
			return getNext()(input, getNext);
		}
	}
}