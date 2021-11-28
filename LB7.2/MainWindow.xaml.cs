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

namespace LB7._2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = textBox1.Text;
                string[] subs = s.Split(',');
                int col = int.Parse(subs[0]);
                int rows = int.Parse(subs[1]);

                string s2 = textBox2.Text;
                string[] subs2 = s2.Split(',');
                int col2 = int.Parse(subs2[0]);
                int rows2 = int.Parse(subs2[1]);

                MyMatrix myMatrix = new MyMatrix();
                myMatrix.Init(col, rows);
                myMatrix.Print(myMatrix.Create());

                MyMatrix myMatrix2 = new MyMatrix();
                myMatrix2.Init(col2, rows2);
                myMatrix2.Print(myMatrix.Create());
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильный ввод! Попробуйте еще раз.");
            }

        }
    }
}
