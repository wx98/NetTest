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
    /// DeleteQuestionWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DeleteQuestionWindow : Window
    {
        WCF.NetTestServiceClient client = new WCF.NetTestServiceClient();
        string url = "http://localhost:8889/NetTestService/";
        DataTable dt;
        DataView dv;
        public DeleteQuestionWindow()
        {
            InitializeComponent();
            client = new WCF.NetTestServiceClient();
            
        }
        void client_deleteTestCompleted(object sender ,WCF.deleteTestCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                DataRow row = dt.AsEnumerable().FirstOrDefault(x => (int)x["ID"] == (int)e.UserState);
                if (row != null)
                {
                    row.Delete();
                    row.AcceptChanges();
                }
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

        private void btGettest_Click(object sender, RoutedEventArgs e)
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
                        client.getTestDataTableAsync();
                    }
                }
                catch(Exception exp)
                {
                    showMsg(exp.Message);
                }
            }
        }
        private void uGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (uGrid.SelectedIndex >= 0)
            {
                txtText.DataContext = dv[uGrid.SelectedIndex];
            }
            else txtText.DataContext = null;
        }
        private void btDeleteTest_Click(object sender, RoutedEventArgs e)
        {
            if (uGrid.SelectedIndex >= 0)
            {
                int index = uGrid.SelectedIndex;
                WCF.TestClass test = new WCF.TestClass { ID = (int)dv[index]["ID"] };
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
                            client.deleteTestAsync(test, test.ID);
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
}
