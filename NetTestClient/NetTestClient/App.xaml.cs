using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NetTestClient
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
    }
    public class Get_Info
    {
        private static string _user;
        private static string _pass;
        public static string User{
            get { return _user;}
            set { _user = value;}
        }
        public static string Pass{
            get { return _pass;}
            set { _pass = value;}
        }
    }
    public class AnswerClass : List<String>
    {
        public AnswerClass()
        {
            Add("A");
            Add("B");
            Add("C");
            Add("D");
        }
    }
    public class JudgmentClass
    {
        bool flag = false;
        public bool Judgment(String txt)
        {
            MessageBoxResult dr = MessageBox.Show(txt, "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (dr == MessageBoxResult.OK)
            {
                return flag = true;
            }
            else
            {
                return flag = false;
            }
        }
        
    }
}
