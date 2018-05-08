using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography;

namespace NetTestClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        WCF.NetTestServiceClient client = new WCF.NetTestServiceClient();
        string url = "http://localhost:8889/NetTestService/";
        public MainWindow()
        {
            InitializeComponent();
            client.loginCompleted += client_loginCompleted;
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri(url, UriKind.Absolute));
        }
        void client_loginCompleted(object sender, WCF.loginCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Option a = new Option();
                a.ShowDialog();
            }
            else
                MessageBox.Show(e.Error.Message);
        }
        string encryptString(string s)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] buf = Encoding.UTF8.GetBytes(s);
            buf = md5.ComputeHash(buf);
            s = "";
            foreach (byte x in buf)
                s = s + x.ToString("X2");
            return s;

        }
        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            string uName = txtUser.Text.Trim();
            string uPass = txtPass.Password.Trim();
            try
            {
                uPass = encryptString(uPass);
                client.loginAsync(new WCF.UserClass { uName = uName, uPass = uPass });
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }
    }
}
