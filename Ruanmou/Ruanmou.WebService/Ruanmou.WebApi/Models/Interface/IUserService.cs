﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.WebApi.Models.Interface
{
	public interface IUserService
	{
		IEnumerable<SysUsers> users();
	}
}
