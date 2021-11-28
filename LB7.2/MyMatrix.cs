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

    class MyMatrix
    {
        
        static int rows;
        static int col;

        public void Init(int a, int b)
        {
            col = a;
            rows = b;
            
        }
        public int[,] Create()
        {
            int[,] myArray = new int[rows, col];
            Random random = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(-5, 5);
                }
            }
            return myArray;
        }
        public void Print(int [,] myArray)
        {
            string text = null;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    text += myArray[i, j] + "\t";
                }
                text += "\n";
            }
            MessageBox.Show($"Ваш массив:\n{text}");
        }
    }
}
