using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace Ruanmou.WCF.Interface
{
	public interface ICallBack
	{
		[OperationContract(IsOneWay =true)]
		void Show();
	}
}
