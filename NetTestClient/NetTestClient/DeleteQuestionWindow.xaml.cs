using System;
using System.Collections.Generic;
using System.Data;
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
        void client_deleteTestCompleted(object sender){}
        
        private void btDeleteTest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btGettest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }
    }
}
