using Ruanmou.WCF.MyTcpCallBack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Ruanmou.WCF.Models
{
	public class CalculatorService : ICalculatorCallback
	{
		public void Show()
		{
			Console.WriteLine("I'm Show....");
		}
	}
}