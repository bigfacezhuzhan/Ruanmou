using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Ruanmou.WCF.Service;

namespace ConsoleApp1
{
	public class ServiceInit
	{
		public static void Process()
		{
			List<ServiceHost> hosts = new List<ServiceHost>()
			{
				new ServiceHost(typeof(CompanyService)),
				new ServiceHost(typeof(Calculator))
			};
			foreach (var host in hosts)
			{
				host.Opening += (s, e) => Console.WriteLine($"{host}服务已开启...");
				host.Open();
			}

			Console.WriteLine("输入任意值关闭服务");
			Console.ReadKey();
			foreach (var item in hosts)
			{
				item.Close();
			}
		}
	}
}
