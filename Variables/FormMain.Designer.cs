namespace Variables
{
    partial class FormMain
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPsevdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStr = new System.Windows.Forms.Button();
            this.buttonObject = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnObject,
            this.ColumnPsevdo,
            this.ColumnInit,
            this.ColumnSize,
            this.ColumnAddress});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 262);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(784, 300);
            this.dataGridView.TabIndex = 6;
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
            // buttonStr
            // 
            this.buttonStr.Location = new System.Drawing.Point(10, 10);
            this.buttonStr.Name = "buttonStr";
            this.buttonStr.Size = new System.Drawing.Size(97, 23);
            this.buttonStr.TabIndex = 7;
            this.buttonStr.Text = "Строки";
            this.buttonStr.UseVisualStyleBackColor = true;
            this.buttonStr.Click += new System.EventHandler(this.buttonStr_Click);
            // 
            // buttonObject
            // 
            this.buttonObject.Location = new System.Drawing.Point(115, 10);
            this.buttonObject.Name = "buttonObject";
            this.buttonObject.Size = new System.Drawing.Size(97, 23);
            this.buttonObject.TabIndex = 8;
            this.buttonObject.Text = "Объекты";
            this.buttonObject.UseVisualStyleBackColor = true;
            this.buttonObject.Click += new System.EventHandler(this.buttonObject_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox.Location = new System.Drawing.Point(0, 42);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(784, 220);
            this.richTextBox.TabIndex = 10;
            this.richTextBox.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.buttonObject);
            this.Controls.Add(this.buttonStr);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переменные";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPsevdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.Button buttonStr;
        private System.Windows.Forms.Button buttonObject;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

