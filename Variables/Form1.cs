using System;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Инициализация размерных переменных
        private void buttonInit_Click(object sender, EventArgs e)
        {
            // Объявление переменных
            unsafe
            {
                string str1;

                // Занесение значений в переменные
                str1 = "Что нибудь";

                // Использование переменных
                dataGridView1.Rows.Add();
                dataGridView1.Rows[0].Cells[0].Value = "System.String";
                dataGridView1.Rows[0].Cells[1].Value = "string";
                dataGridView1.Rows[0].Cells[2].Value = "str1 = " + str1;
                dataGridView1.Rows[0].Cells[3].Value = Convert.ToString(str1.Length);

                string str2;
                str2 = "Вот этот текст будет больше";
                dataGridView1.Rows.Add();
                dataGridView1.Rows[1].Cells[0].Value = "System.String";
                dataGridView1.Rows[1].Cells[1].Value = "string";
                dataGridView1.Rows[1].Cells[2].Value = "str2 = " + str2;
                dataGridView1.Rows[1].Cells[3].Value = Convert.ToString(str2.Length);

                str2 = "Новый текст";

                dataGridView1.Rows.Add();
                dataGridView1.Rows[2].Cells[0].Value = "System.String";
                dataGridView1.Rows[2].Cells[1].Value = "string";
                dataGridView1.Rows[2].Cells[2].Value = "str2 = " + str2;
                dataGridView1.Rows[2].Cells[3].Value = Convert.ToString(str2.Length);

                int i = 50;
                int* ptr;
                ptr = &i;
            }

        }
    }
}
