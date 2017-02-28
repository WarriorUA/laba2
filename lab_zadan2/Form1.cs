using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_zadan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxN.Text);
            int[,] array = new int[n, n];
            string line = richTextBoxArray.Text;
            string[] arrayInt = line.Split(' ', '\n');
            int flag = 0;
            int sumUslov = 0;
            int sumElem = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    array[i, j] = int.Parse(arrayInt[flag]);
                    sumElem += array[i, j];
                    flag++;
                }
            }
            for (int i = 0; i < n; ++i)
            {
                if (array[i, i] < 0)
                {
                    for (int j = 0; j < n; ++j) sumUslov += array[i, j];
                }
            }
            richTextBoxResult.Text += "Среднее арифметическое: \n";
            richTextBoxResult.Text += (sumElem / (n * n)).ToString()+'\n';
            richTextBoxResult.Text += "Сума строк с условием:\n";
            richTextBoxResult.Text += sumUslov.ToString();
        }
    }
}
