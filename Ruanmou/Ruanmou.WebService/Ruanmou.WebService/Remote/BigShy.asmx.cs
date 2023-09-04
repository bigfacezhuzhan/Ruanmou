using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Ruanmou.WebService.Remote
{
	/// <summary>
	/// BigShy 的摘要说明
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
	// [System.Web.Script.Services.ScriptService]
	public class BigShy : System.Web.Services.WebService
	{

		[WebMethod]
		public string HelloWorld()
		{
			return "I'm The shy";
		}
		[WebMethod]
		public int Add(int x,int y)
		{
			return x + y;
		}
		public int Reduce(int x, int y)
		{
			return x - y;
		}
		[WebMethod]
		public List<User> GetShys()
		{
			using(JDDbContext context=new JDDbContext())
			{
				return context.Set<User>().Where(u=>u.Id>100).ToList();
			}
		}
	}
}
