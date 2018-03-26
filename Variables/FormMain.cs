using System;
using System.Windows.Forms;

namespace Variables
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Инициализация размерных переменных
        private void buttonStr_Click(object sender, EventArgs e)
        {
            unsafe
            {
                string str1;

                // Занесение значений в переменные
                str1 = "Что нибудь";

                // Использование переменных
                dataGridView.Rows.Add();
                dataGridView.Rows[0].Cells[0].Value = "System.String";
                dataGridView.Rows[0].Cells[1].Value = "string";
                dataGridView.Rows[0].Cells[2].Value = "str1 = " + str1;
                dataGridView.Rows[0].Cells[3].Value = Convert.ToString(str1.Length);

                string str2;
                str2 = "Вот этот текст будет больше";
                dataGridView.Rows.Add();
                dataGridView.Rows[1].Cells[0].Value = "System.String";
                dataGridView.Rows[1].Cells[1].Value = "string";
                dataGridView.Rows[1].Cells[2].Value = "str2 = " + str2;
                dataGridView.Rows[1].Cells[3].Value = Convert.ToString(str2.Length);

                str2 = "Новый текст";

                dataGridView.Rows.Add();
                dataGridView.Rows[2].Cells[0].Value = "System.String";
                dataGridView.Rows[2].Cells[1].Value = "string";
                dataGridView.Rows[2].Cells[2].Value = "str2 = " + str2;
                dataGridView.Rows[2].Cells[3].Value = Convert.ToString(str2.Length);

                int i = 50;
                int* ptr;
                ptr = &i;
            }

        }

        private void buttonObject_Click(object sender, EventArgs e)
        {
            var objA1 = new ClassObjectA1();
            objA1.Make();

            richTextBox.Clear();
            foreach (var logStr in objA1.LogA1)
            {
                if (!string.IsNullOrEmpty(logStr))
                {
                    richTextBox.AppendText(logStr + Environment.NewLine);
                }
            }
        }
    }
}
