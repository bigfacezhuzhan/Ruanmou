using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ruanmou.WebApi.filter;
using Ruanmou.WebApi.Models;
using Ruanmou.WebApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using Unity;
namespace Ruanmou.WebApi.Controllers
{
    //[BasicAuthorizeFilter]
    //[CusExceptionFilter] //WebApi config 全局配置了
    //ExceptionHandler 全局
    //ActionFilter OnActionExcuting OnActionExcuted
    public class UsersController : ApiController
    {
        private IUserService _UserService = null;
        public UsersController(IUserService userService)
		{
            //throw new Exception("123");
            this._UserService = userService;
		}
        public string GetName(int id)
		{
            IUserService service= ContainerFactory.CreateContainer().Resolve<IUserService>();
            List<SysUsers> list= service.users().ToList();
            return $"{id} {list[0].name}  zhagnsan";
		}


        #region Get请求
        [CusActionFilterAttribute]
        public string GetUserById(int id)
        {
            int id2 = Convert.ToInt32(HttpContext.Current.Request.QueryString["id"]);
            return "kerwin";
        }

        public string GetUserByIdName(int id, string name)
        {
            int id2 = Convert.ToInt32(HttpContext.Current.Request.QueryString["id"]);
            string name2 = HttpContext.Current.Request.QueryString["name"];
            return "kerwin";
        }

        public string GetUserByModel([FromUri] SysUsers user)
        {
            int id2 = Convert.ToInt32(HttpContext.Current.Request.QueryString["id"]);
            string name2 = HttpContext.Current.Request.QueryString["name"];
            return "kerwin";
        }

        public string GetUserBySerializer(string user)
        {
            string userj = HttpContext.Current.Request.QueryString["user"];
            return "Kerwin";
        }
		#endregion

		#region Post请求
        [HttpPost]
        public string RegisterNoKey([FromBody]int id)
		{
            return "RegisterNoKey";
        }

        public string RegisterUser(SysUsers user)
        {
            string id2 = HttpContext.Current.Request.Form["id"];
            return "RegisterUser" + user.id;
        }
        public string RegisterUserJsonObject(user user)
		{
            var id = HttpContext.Current.Request.Form["User[id]"];
            var name = HttpContext.Current.Request.Form["User[name]"];
            var info = HttpContext.Current.Request.Form["info"];
            return "RegisterUserJsonObject";
        }

        public IEnumerable<SysUsers> RegisterUserJData(JObject jData)
        {
            var id = HttpContext.Current.Request.Form["users[id]"];
            var name = HttpContext.Current.Request.Form["users[name]"];
            var info = HttpContext.Current.Request.Form["info"];
            dynamic json = jData;
            JObject user1= json.users;
            string info2 = json.info;
            var user = user1.ToObject<SysUsers>();
            return new List<SysUsers>() { user};
        }
		#endregion

		#region 登录 添加权限认证
        [HttpGet]
        [CusActionFilterAttribute]
        [AllowAnonymous]
        public string login(string account,string password)
		{
			if (account.Equals("admin") && password.Equals("123"))
			{
                FormsAuthenticationTicket ticketObj = new FormsAuthenticationTicket(0, account, DateTime.Now, DateTime.Now.AddMinutes(10), true, $"{account}&{password}", FormsAuthentication.FormsCookieName);
                var rs = new { result = true, ticket = FormsAuthentication.Encrypt(ticketObj) };
                return JsonConvert.SerializeObject(rs);
            }
			else
			{
                var rs = new { result = false };
                return JsonConvert.SerializeObject(rs);
			}
		}
        #endregion

        #region 跨域请求
        /*
            为什么要跨域？(浏览器的同源策略是不允许跨域请求取数据的)
            1.一个页面有N多个请求，为了分担当前服务器的压力
            有哪些方法？
            1.jsonp
            2.CORS 添加引用 配置Ena
		    	config.EnableCors(new EnableCorsAttribute("*", "*", "*"));//允许任意请求
            3.利用ActionFilterAttribute的OnActionExcuted方法添加header
            
         */
        //[CusActionFilter]
        public IEnumerable<string> GetValue()
		{
            return new string[] { "kerwin0", "zhangsna1" };
		}
		#endregion
	}
}
