using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace Ruanmou.WCF.Interface
{
	[ServiceContract(CallbackContract =(typeof(ICallBack)))]
	public interface ICalculator
	{
		[OperationContract(IsOneWay =true)]
		void plus(int x, int y);
	}
}
