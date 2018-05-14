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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“INetTestService”。
    [ServiceContract]
    public interface INetTestService
    {

        [OperationContract]
        string login(UserClass user);
        [OperationContract]
        TestClass addTest(TestClass tset);

        [OperationContract]
        DataTable getTestDataTable();
        [OperationContract]
        bool deleteTest(TestClass test);


        [OperationContract]
        DataTable getUserTestDataTable();
        [OperationContract]
        int setUserMark(int mValue);

        
    }
}
