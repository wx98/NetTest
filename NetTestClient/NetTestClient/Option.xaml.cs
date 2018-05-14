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
            string user = Get_Info.User;
            if (user != "Admin")
            {
                if (btAdd != null && btDelete != null && btUpdate != null)
                {
                    panel.Children.Remove(btAdd);
                    panel.Children.Remove(btDelete);
                    panel.Children.Remove(btUpdate);
                }
            }
        }

        private void Add_Question_Click(object sender, RoutedEventArgs e)
        {
            AddQuestionWindow addWindow = new AddQuestionWindow();
            addWindow.ShowDialog();
        }

        private void Delete_Question_Click(object sender, RoutedEventArgs e)
        {
            DeleteQuestionWindow deletewindow = new DeleteQuestionWindow();
            deletewindow.ShowDialog();

        }

        private void Update_Question_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exercise_Question_Click(object sender, RoutedEventArgs e)
        {
            ExerciseWindow exercisewindow = new ExerciseWindow();
            exercisewindow.ShowDialog();
        }

        
    }
}
