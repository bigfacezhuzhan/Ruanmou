using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Ruanmou.WebApi.Models.Log4
{
	public class Log4Factory
	{
		static Log4Factory()
		{
			XmlConfigurator.Configure(new FileInfo(Path.Combine(HttpRuntime.BinDirectory, "CfgFiles\\Log4net.cfg.xml")));
			ILog loger = LogManager.GetLogger(typeof(Log4Factory));
			loger.Info("初始化日志类 Logger");
		}
		ILog log = null;
		public Log4Factory(Type type)
		{
			log = LogManager.GetLogger(type);
		}
		public void Info(string msg = "消息")
		{
			log.Info(msg);
		}
		public void Error(string msg = "出现异常")
		{
			log.Error(msg);
		}
		public void Fatal(string msg = "出现异常")
		{
			log.Fatal(msg);
		}
		public void Warn(string msg = "出现警告")
		{
			log.Warn(msg);
		}
	}
}