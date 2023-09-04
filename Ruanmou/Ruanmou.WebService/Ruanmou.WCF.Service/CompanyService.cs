using Ruanmou.WCF.Interface;
using Ruanmou.WCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.WCF.Service
{
    public class CompanyService: ICompanyService
    {
		public int Add(int x, int y)
		{
			return x + y;
		}

		public List<SysUser> GetListUser()
		{
			return new List<SysUser>()
			{
				new SysUser { id=1,name="张三",description= "张张张张张",whats="what's up?" },
				new SysUser { id=2,name="李四",description= "李李李李李",whats="what's up?" },
				new SysUser { id=3,name="王五",description= "王王王王王",whats="what's up?" },
			};
		}

		public SysUser GetUser()
		{
			return new SysUser { id=1,name="张三",description= "张张张张张",whats="what's up?" };
		}
	}
}
