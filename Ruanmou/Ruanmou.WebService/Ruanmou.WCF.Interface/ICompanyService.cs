using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Ruanmou.WCF.Model;
namespace Ruanmou.WCF.Interface
{
    [ServiceContract]
    public interface ICompanyService
    {
        [OperationContract]
        int Add(int x, int y);

        [OperationContract]
        SysUser GetUser();

        [OperationContract]
        List<SysUser> GetListUser();
    }
}
