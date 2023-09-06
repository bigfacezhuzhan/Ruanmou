using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ruanmou.WebApi.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[Route("api/values/{id:int}")]
		public string Get(int id)
		{
			return "value";
		}
		public string Get(string id)
		{
			return "value";
		}
		[Route("api/values/{id}/str")]
		public string GetString(string id)
		{
			return "GetString value";
		}
		// POST api/values
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
