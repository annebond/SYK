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
using WpfApp1.SR2;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SR2.Service2Client service2 = new SR2.Service2Client();
            service2.DoWorkCompleted += service2_DoWorkCompleted;
            service2.DoWorkAsync(Convert.ToDouble(TextBox2.Text), Convert.ToDouble(TextBox3.Text));
            //TextBox1.Text = service2.DoWork(Convert.ToDouble(TextBox2.Text), Convert.ToDouble(TextBox3.Text)).ToString();
        }

        private void service2_DoWorkCompleted(object sender, DoWorkCompletedEventArgs e)
        {
            TextBox1.Text = e.Result.ToString();
        }
    }
}
