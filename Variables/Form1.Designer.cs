namespace Variables
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonInit = new System.Windows.Forms.Button();
            this.ColumnObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPsevdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonInit);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 550);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размерные (В байтах)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnObject,
            this.ColumnPsevdo,
            this.ColumnInit,
            this.ColumnSize,
            this.ColumnAddress});
            this.dataGridView1.Location = new System.Drawing.Point(5, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(5, 458);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(97, 23);
            this.buttonInit.TabIndex = 1;
            this.buttonInit.Text = "Инициализация";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // ColumnObject
            // 
            this.ColumnObject.HeaderText = "Объект";
            this.ColumnObject.Name = "ColumnObject";
            // 
            // ColumnPsevdo
            // 
            this.ColumnPsevdo.HeaderText = "Псевдоним";
            this.ColumnPsevdo.Name = "ColumnPsevdo";
            // 
            // ColumnInit
            // 
            this.ColumnInit.HeaderText = "Инициализация";
            this.ColumnInit.Name = "ColumnInit";
            this.ColumnInit.Width = 200;
            // 
            // ColumnSize
            // 
            this.ColumnSize.HeaderText = "Размер";
            this.ColumnSize.Name = "ColumnSize";
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Адрес";
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с переменными";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPsevdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
    }
}

