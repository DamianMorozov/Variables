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

        // Строки
        private void buttonStr_Click(object sender, EventArgs e)
        {
            unsafe
            {
                // Занесение значений в переменные
                const string str1 = "Что нибудь";

                // Использование переменных
                dataGridView.Rows.Add();
                dataGridView.Rows[0].Cells[0].Value = "System.String";
                dataGridView.Rows[0].Cells[1].Value = "string";
                dataGridView.Rows[0].Cells[2].Value = "str1 = " + str1;
                dataGridView.Rows[0].Cells[3].Value = Convert.ToString(str1.Length);

                var str2 = "Вот этот текст будет больше";
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

        // Объекты классов
        private void buttonObject_Click(object sender, EventArgs e)
        {
            // Очистить лог
            richTextBox.Clear();

            var objA1 = new ClassObjectA1();
            richTextBox.AppendText("var objA1 = new ClassObjectA1();" + Environment.NewLine + Environment.NewLine);

            foreach (var logStr in objA1.Log)
            {
                if (!string.IsNullOrEmpty(logStr))
                {
                    richTextBox.AppendText(logStr + Environment.NewLine);
                }
            }
        }

        // Объект класса с методом virtual
        private void buttonObjectVirtual_Click(object sender, EventArgs e)
        {
            // Очистить лог
            richTextBox.Clear();

            var objB = new ClassObjectB();
            richTextBox.AppendText("var objB = new ClassObjectB();" + Environment.NewLine + Environment.NewLine);

            foreach (var logStr in objB.Log)
            {
                if (!string.IsNullOrEmpty(logStr))
                {
                    richTextBox.AppendText(logStr + Environment.NewLine);
                }
            }
        }

        // Объект класса с методом override
        private void buttonObjectOverride_Click(object sender, EventArgs e)
        {
            // Очистить лог
            richTextBox.Clear();

            var objB1 = new ClassObjectB1();
            richTextBox.AppendText("var objB1 = new ClassObjectB1();" + Environment.NewLine + Environment.NewLine);

            foreach (var logStr in objB1.Log)
            {
                if (!string.IsNullOrEmpty(logStr))
                {
                    richTextBox.AppendText(logStr + Environment.NewLine);
                }
            }

            richTextBox.AppendText(Environment.NewLine + Environment.NewLine);

            var objB2 = new ClassObjectB2();
            richTextBox.AppendText("var objB2 = new ClassObjectB2();" + Environment.NewLine + Environment.NewLine);

            foreach (var logStr in objB2.Log)
            {
                if (!string.IsNullOrEmpty(logStr))
                {
                    richTextBox.AppendText(logStr + Environment.NewLine);
                }
            }
        }

    }
}
