using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ruanmou.WCF.Remote
{
	// 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“BigZhanWcf”。
	// 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 BigZhanWcf.svc 或 BigZhanWcf.svc.cs，然后开始调试。
	public class BigZhanWcf : IBigZhanWcf
	{
		public void DoWork()
		{

		}
		public string GetStr()
		{
			return "My Wcf";
		}
		public List<User> GetUserList()
		{
			return new List<User>() { new User() { Id = 1, Account = "123" } };
		}
		public List<Animal> GetAnimal()
		{
			return new List<Animal>() { new Animal { id = 1 ,name="cat",description="喵喵"} };
		}
	}
}
