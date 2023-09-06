using Ruanmou.WebApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ruanmou.WebApi.Models.Service
{
	public class UserService: IUserService
	{
		private DbContext context = null;
		public UserService(DbContext context)
		{
			this.context = context;
		}

		public IEnumerable<SysUsers> users()
		{
			return new List<SysUsers>() { new SysUsers() { id=1,name="zs"} };
		}
	}
}