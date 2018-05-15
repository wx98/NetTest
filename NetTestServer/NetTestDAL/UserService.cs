using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTestModel;
using System.Data;

namespace NetTestDAL
{
    public class UserService
    {
        //login()
        //完成用户的登录或注册
        //返回用户的三种状态
        public string login(UserClass user)
        {
            string s = "failed";
            using (SqlConnection con = new SqlConnection(DBHelper.conString))
            {
                DBHelper DB = new DBHelper(con);
                SqlParameter pName = new SqlParameter("@uName", SqlDbType.Char);
                pName.Value = user.uName;
                SqlParameter pPass = new SqlParameter("@uPass", SqlDbType.Char);
                pPass.Value = user.uPass;
                try
                {
                    DB.executeCommand("insert into users values(@uName,@uPass)", pName, pPass);
                    s = "registered";

                }
                catch
                {
                    if (DB.getScalar("select count(*) from users where uName=@uName and uPass=@uPass", pName, pPass) > 0)
                        s = "logined";
                    else
                        s = "failed";

                }
                con.Close();
            }
            return s;

        }
    }

}
