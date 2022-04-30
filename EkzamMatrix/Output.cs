using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzamMatrix
{
    public class Output
    {
        public void output(MainWindow MW)
        {
            MW.matrixTextBox.Clear();
            MW.resultTextBox.Clear();

            Random rand = new Random();
            int[,] a = new int[6, 6];

            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    a[i, j] = rand.Next(1, 10);
                    MW.matrixTextBox.Text += a[i, j] + " ";
                }
                MW.matrixTextBox.Text += "\n";
            }



            for (int i = 1; i < a.GetLength(0); i += 2)
            {
                if (a[i, 0] > a[i, a.GetLength(1) - 1])
                {
                    for (int j = 0; j < a.GetLength(1); ++j)
                    {
                        MW.resultTextBox.Text += a[i, j] + " ";
                    }
                }
                MW.resultTextBox.Text += "\n";
            }
        }

        public int ResultTest(int x)
        {
            int[] mas = new int[x];
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(6, 6);
                x = mas[i];
            }
            return x;
        }
    }
}
