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
using System.Windows.Shapes;

namespace NetTestClient
{
    /// <summary>
    /// Option.xaml 的交互逻辑
    /// </summary>
    public partial class Option : Window
    {
        public Option()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Option a = new Option();
            a.ShowDialog();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Option a = new Option();
            a.ShowDialog();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Option a = new Option();
            a.ShowDialog();
        }

        private void Exercise_Click(object sender, RoutedEventArgs e)
        {
            Option a = new Option();
            a.ShowDialog();
        }
    }
}
