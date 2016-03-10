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

namespace TestApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int a = 0;
            if(a == 5)
            {
                int b = 3;
            }

            

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Blaaaaa");
            
        }

        public static int testClick(int input)
        {
            return input;
        }

        private class AnotherClass
        {
            private int _count { get; set; }

            public AnotherClass(int count)
            {
                _count = count;
            }
        }
    }
}
