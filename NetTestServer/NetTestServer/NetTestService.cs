using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NetTestModel;
using NetTestBLL;

namespace NetTestSever
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“NetTestService”。
    public class NetTestService : INetTestService
    {
        public void DoWork()
        {
        }
        public string login(UserClass user)
        {
            UserManager manager = new UserManager();
            return manager.login(user);
        }
    }
}
