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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // SR1.IService1 service1 = new SR1.IService1 (); // das geht nicht, nur service instanzieren geht nicht
            SR1.Service1Client service1 = new SR1.Service1Client();
            Textbox1.Text = service1.GetData(Convert.ToInt32(Textbox1.Text));
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            SR2.Service2Client service2 = new SR2.Service2Client();
            Textbox2.Text = service2.DoWork(Convert.ToDouble(Textbox2.Text)).ToString(); //to string weil die textbox einen string erwartet
        }
    }
}
    