using System;
namespace FB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SharePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumbersShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YouShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.купівляПродажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.CompanyName,
            this.SharePrice,
            this.NumbersShares,
            this.YouShares,
            this.ValueChange});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(653, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // number
            // 
            this.number.HeaderText = "Номер";
            this.number.Name = "number";
            this.number.Width = 50;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Імя компанії";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 200;
            // 
            // SharePrice
            // 
            this.SharePrice.HeaderText = "Ціна акцій";
            this.SharePrice.Name = "SharePrice";
            // 
            // NumbersShares
            // 
            this.NumbersShares.HeaderText = "Кількість акцій";
            this.NumbersShares.Name = "NumbersShares";
            // 
            // YouShares
            // 
            this.YouShares.HeaderText = "Ваші акції";
            this.YouShares.Name = "YouShares";
            // 
            // ValueChange
            // 
            this.ValueChange.HeaderText = "Зміна ціни";
            this.ValueChange.Name = "ValueChange";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Наступний  день";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.купівляПродажToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // купівляПродажToolStripMenuItem
            // 
            this.купівляПродажToolStripMenuItem.Name = "купівляПродажToolStripMenuItem";
            this.купівляПродажToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.купівляПродажToolStripMenuItem.Text = "Купівля/Продаж";
            this.купівляПродажToolStripMenuItem.Click += new System.EventHandler(this.купівляПродажToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCompanyToolStripMenuItem,
            this.deleteCompanyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.editToolStripMenuItem.Text = "Редагування списку";
            // 
            // addCompanyToolStripMenuItem
            // 
            this.addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            this.addCompanyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addCompanyToolStripMenuItem.Text = "Добавить Компанію";
            this.addCompanyToolStripMenuItem.Click += new System.EventHandler(this.addCompanyToolStripMenuItem_Click);
            // 
            // deleteCompanyToolStripMenuItem
            // 
            this.deleteCompanyToolStripMenuItem.Name = "deleteCompanyToolStripMenuItem";
            this.deleteCompanyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.deleteCompanyToolStripMenuItem.Text = "Видалити компанію";
            this.deleteCompanyToolStripMenuItem.Click += new System.EventHandler(this.deleteCompanyToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ваш баланс:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Імітація роботи фондової біржі";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCompanyToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem купівляПродажToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SharePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumbersShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn YouShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueChange;
    }

}

