using System;
using System.Collections.Generic;
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
    /// AddQuestionWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddQuestionWindow : Window
    {
        WCF.NetTestServiceClient client = new WCF.NetTestServiceClient();
        string url = "http://localhost:8889/NetTestService/";

        public AddQuestionWindow()
        {
            InitializeComponent();
            client = new WCF.NetTestServiceClient();
            client.addTestCompleted += client_addTestCompleted;
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri(url, UriKind.Absolute));
            cbAnswer.Items.Add("A");
            cbAnswer.Items.Add("B");
            cbAnswer.Items.Add("C");
            cbAnswer.Items.Add("D");
            cbAnswer.SelectedIndex = 0;
        }
        void client_addTestCompleted(object sender, WCF.addTestCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                WCF.TestClass test = e.Result;
                if (test.ID > 0) txtMsg.Text = "上传成功 ID = " + test.ID.ToString();
            }
            else
                MessageBox.Show(e.Error.Message);
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

        private void btUpLoad_Click(object sender, RoutedEventArgs e)
        {
            String uName = Get_Info.User;
            String uPass = Get_Info.Pass;
            String tTitle = txtTitle.Text.Trim();
            String text = txtText.Text.Trim();
            if (uName != "" && uPass != "" && tTitle != "" && text != "")
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
                        WCF.TestClass test = new WCF.TestClass
                        {
                            ID = 0,
                            tAnswer = cbAnswer.SelectedItem.ToString(),
                            tTitle = tTitle,
                            tText = text
                        };
                        client.addTestAsync(test);
                    }
                }
                catch(Exception exp)
                {
                    showMsg(exp.Message);
                }
            }

        }
    }
}
