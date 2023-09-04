using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ruanmou.WCF.Remote
{
	// 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IBigZhanWcf”。
	[ServiceContract]
	public interface IBigZhanWcf
	{
		[OperationContract]
		void DoWork();
		[OperationContract]
		string GetStr();
		[OperationContract]
		List<User> GetUserList();
		[OperationContract]
		List<Animal> GetAnimal();
	}
}
