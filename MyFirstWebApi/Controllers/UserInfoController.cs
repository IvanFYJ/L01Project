using entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWebApi.Controllers
{
    /// <summary>
    /// 用户数据控制器
    /// </summary>
    public class UserInfoController : ApiController
    {
        BLL_UserInfo BLL = new BLL_UserInfo();

        public IEnumerable<UserInfo> Get()
        {
            return BLL.Get();
        }
    }
}
