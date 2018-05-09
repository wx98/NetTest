using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTestModel;
using NetTestDAL;

namespace NetTestBLL
{
    public class UserManager
    {
        public string login(UserClass user)
        {
            UserService service = new UserService();
            return service.login(user);
        }
    }
}
