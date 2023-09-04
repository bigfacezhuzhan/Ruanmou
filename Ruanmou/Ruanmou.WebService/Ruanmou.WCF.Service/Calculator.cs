using Ruanmou.WCF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Ruanmou.WCF.Service
{
	public class Calculator : ICalculator
	{
		public void plus(int x, int y)
		{
			Console.WriteLine(x + y);
			Thread.Sleep(2000);
			ICallBack call= OperationContext.Current.GetCallbackChannel<ICallBack>();
			call.Show();
		}
	}
}
