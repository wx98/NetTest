using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NetTestModel;
using NetTestBLL;
using System.Data;

namespace NetTestSever
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“NetTestService”。
    public class NetTestService : INetTestService
    {
        
        public string login(UserClass user)
        {
            UserManager manager = new UserManager();
            return manager.login(user);
        }
        
        UserClass getUser()
        {
           
            String uName = OperationContext.Current.IncomingMessageHeaders.GetHeader<String>("uName", "MySpace");
            String uPass = OperationContext.Current.IncomingMessageHeaders.GetHeader<String>("uPass", "MySpace");
            return new UserClass { uName = uName, uPass = uPass };
        }

        public TestClass addTest(TestClass test) 
        {
            TestManager manager = new TestManager();
            manager.addTest(getUser(), ref test);
            return test;
        }

        public DataTable getTestDataTable()
        {
            TestManager manager = new TestManager();
            return manager.getTestDataTable(getUser());
        }
        public bool deleteTest(TestClass test)
        {
            TestManager manager = new TestManager();
            return manager.deleteTest(getUser(), test);
        }

        public DataTable getUserTestDataTable()
        {
            TestManager manager = new TestManager();
            return manager.getTestDataTable(getUser());
        }
        public int setUserMark(int mValue)
        {
            TestManager manager = new TestManager();
            return manager.setUserMark(getUser(),mValue);
        }

    }
}
