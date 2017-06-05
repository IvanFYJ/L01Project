using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entites
{
    public class BLL_UserInfo
    {
        /// <summary>
        /// 创建样例数据
        /// </summary>
        private List<UserInfo> Data = new List<UserInfo>() {
            new UserInfo() {
                Id = 1,
                Age= 10,
                Name = "哈哈"
            },
            new UserInfo()
            {
                Id = 2,
                Age = 22,
                Name = "嘿嘿"
            }
        };

        /// <summary>
        /// 获取样例数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserInfo> Get()
        {
            return Data;
        }
    }
}
