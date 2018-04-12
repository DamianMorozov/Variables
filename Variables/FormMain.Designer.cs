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
            this.buttonStrings = new System.Windows.Forms.Button();
            this.buttonObjects = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonObjectOverride = new System.Windows.Forms.Button();
            this.buttonObjectVirtual = new System.Windows.Forms.Button();
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
            // buttonStrings
            // 
            this.buttonStrings.Location = new System.Drawing.Point(10, 10);
            this.buttonStrings.Name = "buttonStrings";
            this.buttonStrings.Size = new System.Drawing.Size(97, 23);
            this.buttonStrings.TabIndex = 7;
            this.buttonStrings.Text = "Строки";
            this.buttonStrings.UseVisualStyleBackColor = true;
            this.buttonStrings.Click += new System.EventHandler(this.buttonStr_Click);
            // 
            // buttonObjects
            // 
            this.buttonObjects.Location = new System.Drawing.Point(115, 10);
            this.buttonObjects.Name = "buttonObjects";
            this.buttonObjects.Size = new System.Drawing.Size(150, 23);
            this.buttonObjects.TabIndex = 8;
            this.buttonObjects.Text = "Объекты классов";
            this.buttonObjects.UseVisualStyleBackColor = true;
            this.buttonObjects.Click += new System.EventHandler(this.buttonObject_Click);
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
            // buttonObjectOverride
            // 
            this.buttonObjectOverride.Location = new System.Drawing.Point(485, 10);
            this.buttonObjectOverride.Name = "buttonObjectOverride";
            this.buttonObjectOverride.Size = new System.Drawing.Size(200, 23);
            this.buttonObjectOverride.TabIndex = 11;
            this.buttonObjectOverride.Text = "Объект класса с методом override";
            this.buttonObjectOverride.UseVisualStyleBackColor = true;
            this.buttonObjectOverride.Click += new System.EventHandler(this.buttonObjectOverride_Click);
            // 
            // buttonObjectVirtual
            // 
            this.buttonObjectVirtual.Location = new System.Drawing.Point(275, 10);
            this.buttonObjectVirtual.Name = "buttonObjectVirtual";
            this.buttonObjectVirtual.Size = new System.Drawing.Size(200, 23);
            this.buttonObjectVirtual.TabIndex = 12;
            this.buttonObjectVirtual.Text = "Объект класса с методом virtual";
            this.buttonObjectVirtual.UseVisualStyleBackColor = true;
            this.buttonObjectVirtual.Click += new System.EventHandler(this.buttonObjectVirtual_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.buttonObjectVirtual);
            this.Controls.Add(this.buttonObjectOverride);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.buttonObjects);
            this.Controls.Add(this.buttonStrings);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Button buttonStrings;
        private System.Windows.Forms.Button buttonObjects;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonObjectOverride;
        private System.Windows.Forms.Button buttonObjectVirtual;
    }
}

