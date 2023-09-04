using Ruanmou.WCF.Models;
using Ruanmou.WCF.MyTcpCallBack;
using Ruanmou.WCF.MyTcpWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace Ruanmou.WCF.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			//CompanyServiceClient client = null;
			CalculatorClient client = null;
			try
			{
				//client = new CompanyServiceClient();
				//List<SysUser> users= client.GetListUser();
				//client.Close();
				InstanceContext context = new InstanceContext(new CalculatorService());
				client = new CalculatorClient(context);
				client.plus(1,2);
				client.Close();
			}
			catch (Exception ex)
			{
				if (client != null)
					client.Abort();
				throw ex;
			}
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}