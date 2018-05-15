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
        //verifyAdmin()
        //管理员身份验证函数;
        bool verifyAdmin(DBHelper DB,UserClass user)
        {
            if (user.uName == "Admin")
            {
                SqlParameter pName = new SqlParameter("@uName", SqlDbType.Char);
                pName.Value = user.uName;
                SqlParameter pPass = new SqlParameter("@uPass", SqlDbType.Char);
                pPass.Value = user.uPass;
                return ((int)DB.getScalar("select count (*) from users where uName = @uName and uPass = @uPass",pName,pPass) > 0);
            }
            return false; 
        }
        //verifyUser()
        //已注册用户身份验证函数
        bool verifyUser(DBHelper DB, UserClass user)
        {
        
            SqlParameter pName = new SqlParameter("@uName", SqlDbType.Char);
            pName.Value = user.uName;
            SqlParameter pPass = new SqlParameter("@uPass", SqlDbType.Char);
            pPass.Value = user.uPass;
            return ((int)DB.getScalar("select count (*) from users where uName = @uName and uPass = @uPass", pName, pPass) > 0);
        }

        //addTest()
        //添加试题函数
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
                    pText.Value = test.tText;
                    SqlParameter pAnswer = new SqlParameter("@tAnswer", SqlDbType.Char);
                    pAnswer.Value = test.tAnswer;
                    if (DB.executeCommand("insert into tests (tDate,tTitle,tText,tAnswer) values (@tDate,@tTitle,@tText,@tAnswer)", pDate, pTitle, pText, pAnswer) > 0)
                    {
                        test.ID = DB.getScalar("select top 1 ID from tests order by ID desc");
                    }
                }
                con.Close();
            }
            return test.ID;
        }

        //getTestDataTable()
        //获得试题表函数
        public DataTable getTestDataTable(UserClass user)
        {
            DataTable dt = null;
            using (SqlConnection con = new SqlConnection(DBHelper.conString))
            {
                DBHelper DB = new DBHelper(con);
                if (verifyAdmin(DB, user))
                {
                    SqlDataAdapter adapter = DB.getAdapter("select ID,tDate,tTitle,tAnswer,tText from tests order by ID");
                    adapter.SelectCommand = DBHelper.cmd;
                    dt = new DataTable("Test");
                    adapter.Fill(dt);
                }
                con.Close();
            }
            return dt;
        }

        //deleteTest()
        //删除除试题函数
        public bool deleteTest(UserClass user, TestClass test)
        {
            bool flag = false;
            using (SqlConnection con = new SqlConnection(DBHelper.conString))
            {
                DBHelper DB = new DBHelper(con);
                if (verifyAdmin(DB, user))
                {
                    if (DB.executeCommand("delete from tests where ID = "+test.ID.ToString()) > 0)
                        flag = true;
                }
                con.Close();
            }
            return flag;
        }

        //getUserTestDataTable()
        //随机获得10个试题表函数
        public DataTable getUserTestDataTable(UserClass user)
        {
            Random rnd = new Random();
            DataTable dt = null;
            using (SqlConnection con = new SqlConnection(DBHelper.conString))
            {
                DBHelper DB = new DBHelper(con);
                if (verifyUser(DB, user))
                {
                    SqlDataAdapter adapter = DB.getAdapter("select top 10 * from tests order by NEWID()");
                    adapter.SelectCommand = DBHelper.cmd;
                    dt = new DataTable("Test");
                    adapter.Fill(dt);
                }
                con.Close();
            }
            return dt;
        }

        //setUserMark()
        //设置用户成绩函数
        public int setUserMark(UserClass user, int mValue)
        {
            int flag = -1;
            using (SqlConnection con = new SqlConnection(DBHelper.conString))
            {
                DBHelper DB = new DBHelper(con);
                if (verifyUser(DB, user))
                {
                    SqlParameter pName= new SqlParameter("@uName", SqlDbType.Char);
                    pName.Value = user.uName;
                    SqlParameter pDate = new SqlParameter("@mDate", SqlDbType.Char);
                    pDate.Value = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
                    SqlParameter pValue = new SqlParameter("@mValue", SqlDbType.Int);
                    pValue.Value = mValue;

                    if (DB.executeCommand("insert into marks (uName,mDate,mValue) values (@uName,@mDate,@mValue)", pName, pDate, pValue) > 0)
                    {
                        flag = mValue;
                    }
                }
                con.Close();
            }
            return flag;
        }


    }
}
