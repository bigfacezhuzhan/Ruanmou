using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.WCF.Model
{
	[DataContract]
	public class SysUser
	{
		[DataMember]
		public int id { get; set; }
		[DataMember]
		public string name { get; set; }
		[DataMember(Name ="descri")]
		public string description { get; set; }
		public string whats { get; set; }
	}
}
