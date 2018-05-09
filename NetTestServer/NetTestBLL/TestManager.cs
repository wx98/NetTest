using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTestModel;
using NetTestDAL;

namespace NetTestBLL
{
    public class TestManager
    {
        public int addTest(UserClass user, ref TestClass test)
        {
            TestService service = new TestService();
            return service.addTest(user, ref test);
        }
    }
}
