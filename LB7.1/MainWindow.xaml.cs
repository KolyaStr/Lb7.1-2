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

namespace LB7._1
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
                string text1 = textBox1.Text;
                string array = text1;
                int[] myArray = array.Split(',').Select(Int32.Parse).ToArray();
                int max = myArray.Max();
                int min = myArray.Min();
                int sum = myArray.Sum();
                double avg = myArray.Average();
                string str = null;
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] % 2 != 0)
                    {
                        str +=myArray[i] + " ";
                    }
                }
                if (text1 != "")
                {
                    MessageBox.Show($"Максимальное значение массива {max}, минимальное {min}, сумма элементов массива {sum}, среднее значение {Math.Round(avg, 2)}, непарные значения: {str}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильный ввод массива! Попробуйте еще раз.");
            }
        }
    }
}
