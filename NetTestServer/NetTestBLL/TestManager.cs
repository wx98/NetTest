using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTestModel;
using NetTestDAL;
using System.Data;

namespace NetTestBLL
{
    public class TestManager
    {
        public int addTest(UserClass user, ref TestClass test)
        {
            TestService service = new TestService();
            return service.addTest(user, ref test);
        }
        public DataTable getTestDataTable(UserClass user)
        {
            TestService service = new TestService();
            return service.getTestDataTable(user);
        }
        public bool deleteTest(UserClass user, TestClass test)
        {
            TestService service = new TestService();
            return service.deleteTest(user, test);
        }
    }
}
