using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTestModel;
using System.Data.SqlClient;
using System.Data;

namespace NetTestDAL
{
    public class TestService
    {
        bool verifyAdmin(DBHelper DB,UserClass user)
        {
            if (user.uName == "Admin")
            {
                SqlParameter pName = new SqlParameter("@uName", SqlDbType.Char);
                pName.Value = user.uName;
                SqlParameter pPass = new SqlParameter("@uPass", SqlDbType.Char);
                pPass.Value = user.uPass;
                return ((int)DB.getScalar("select count (*) from users where iName = @ uName and uPass = @uPass",pName,pPass) > 0);
            }
            return false; 
        }

        public int addTest(UserClass user, ref TestClass test)
        {
            test.ID = 0;
             using (SqlConnection con = new SqlConnection(DBHelper.conString))
            {
                DBHelper DB = new DBHelper(con);
                if (verifyAdmin(DB, user))
                {
                    SqlParameter pDate = new SqlParameter("@tDate", SqlDbType.Char);
                    pDate.Value = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
                    SqlParameter pTitle = new SqlParameter("@tTitle", SqlDbType.Char);
                    pTitle.Value = test.tTitle;
                    SqlParameter pText = new SqlParameter("@tText", SqlDbType.Text);
                    pTitle.Value = test.tText;
                    SqlParameter pAnswer = new SqlParameter("@tAnswer", SqlDbType.Char);
                    pTitle.Value = test.tAnswer;
                    if (DB.executeCommand("indert into tests (tDate,tTitle,tText,tAnswer) values (@tDate,@tTitle,@tText,@tAnswer)", pDate, pTitle, pText, pAnswer) > 0)
                    {
                        test.ID = DB.getScalar("select top 1 ID from tests order by ID desc");
                    }
                }
                con.Close();
            }
            return test.ID;
        } 
    }
}
