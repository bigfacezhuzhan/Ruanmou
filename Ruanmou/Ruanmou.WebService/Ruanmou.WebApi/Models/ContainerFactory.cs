﻿using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Unity;

namespace Ruanmou.WebApi.Models
{
	public class ContainerFactory
	{
		private static IUnityContainer _IUnityContainer = null;
		static ContainerFactory()
		{
			ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
			fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CfgFiles\\Unity.Config");//找配置文件的路径
			Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
			UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);
			_IUnityContainer = new UnityContainer();
			section.Configure(_IUnityContainer, "apiContainer");
		}
		public static IUnityContainer CreateContainer()
		{
			return _IUnityContainer;
		}
	}
}