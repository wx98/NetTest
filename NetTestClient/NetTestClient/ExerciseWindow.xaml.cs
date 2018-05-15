
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NetTestClient
{
    /// <summary>
    /// ExerciseWindow.xaml 的交互逻辑
    /// </summary>
    /// 
    public class AnswerClass : List<String>
    {
        public AnswerClass()
        {
            Add("A"); Add("B"); Add("C"); Add("D");
        }
    }
    public partial class ExerciseWindow : Window
    {
        WCF.NetTestServiceClient client = new WCF.NetTestServiceClient();
        string url = "http://localhost:8889/NetTestService/";
        DataTable dt;
        DataView dv;
        public ExerciseWindow()
        {

            InitializeComponent();
            client = new WCF.NetTestServiceClient();
            client.getUserTestDataTableCompleted += client_getUserTestDataTableCompleted;
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri(url, UriKind.Absolute));
            btHandleTest.IsEnabled = false;
            
            
        }
        void client_getUserTestDataTableCompleted(object sender, WCF.getUserTestDataTableCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                dt = e.Result;
                dt.Columns.Add("tNo");
                dt.Columns.Add("uAnswer");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["tNo"] = (i + 1).ToString();
                    dt.Rows[i]["uAnswer"] = "";
                }
                dt.AcceptChanges();
                dv = dt.DefaultView;
                uGrid.ItemsSource = dv;
                btGetTest.IsEnabled = false;
                btHandleTest.IsEnabled = true;
            }
            else showMsg(e.Error.Message);
        }
    
        void showMsg(String s)
        {
            MessageBox.Show(s, "Information", MessageBoxButton.OK);
        }
        String encryptString(String s)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] buf = Encoding.UTF8.GetBytes(s);
            buf = md5.ComputeHash(buf);
            s = "";
            foreach (byte x in buf)
                s = s + x.ToString("X2");
            return s;
        }

        private void uGrid_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (uGrid.SelectedIndex >= 0)
            {
                txtText.DataContext = dv[uGrid.SelectedIndex];
            }
            else
            {
                txtText.DataContext = null;
            }
        }
        private void btHandleTest_Click(object sender, RoutedEventArgs e)
        {
            int mValue = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["tAnswer"].ToString() == row["uAnswer"].ToString())
                    ++mValue;
            }
            msg.Text = "成绩:" + mValue.ToString();
            btHandleTest.IsEnabled = true;
            String uName =  Get_Info.User;
            String uPass = Get_Info.Pass;
            if (uName != "" && uPass != "")
            {
                try
                {
                    uPass = encryptString(uPass);
                    using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
                    {
                        MessageHeader user = MessageHeader.CreateHeader("uName", "MySpace", uName);
                        MessageHeader pass = MessageHeader.CreateHeader("uPass", "MySpace", uPass);
                        OperationContext.Current.OutgoingMessageHeaders.Add(user);
                        OperationContext.Current.OutgoingMessageHeaders.Add(pass);
                        client.setUserMarkAsync(mValue);
                    }
                }
                catch (Exception exp)
                {
                    showMsg(exp.Message);
                }
            }
            
        }
        

        private void btGetTest_Click(object sender, RoutedEventArgs e)
        {
            String uName = Get_Info.User;
            String uPass = Get_Info.Pass;
            if (uName != "" && uPass != "")
            {
                try
                {
                    uPass = encryptString(uPass);
                    using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
                    {
                        MessageHeader user = MessageHeader.CreateHeader("uName", "MySpace", uName);
                        MessageHeader pass = MessageHeader.CreateHeader("uPass", "MySpace", uPass);
                        OperationContext.Current.OutgoingMessageHeaders.Add(user);
                        OperationContext.Current.OutgoingMessageHeaders.Add(pass);
                        client.getUserTestDataTableAsync();
                    }
                }
                catch (Exception exp)
                {
                    showMsg(exp.Message);
                }
            }
        } 
    }
}
