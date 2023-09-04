using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ruanmou.WCF.Remote
{
	[DataContract]
	public class Animal
	{
		[DataMember]
		public int id { get; set; }
		[DataMember(Name ="ShortName")]
		public string name { get; set; }
		public string description { get; set; }
	}
}