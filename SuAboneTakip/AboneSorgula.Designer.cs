﻿namespace WP_SuAboneTakip
{
    partial class AboneSorgula
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AboneDataGrid = new System.Windows.Forms.DataGridView();
            this.aboneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aboneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eskiBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AboneDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AboneID";
            // 
            // AboneDataGrid
            // 
            this.AboneDataGrid.AutoGenerateColumns = false;
            this.AboneDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AboneDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aboneIDDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.eskiBorcDataGridViewTextBoxColumn});
            this.AboneDataGrid.DataSource = this.aboneBindingSource;
            this.AboneDataGrid.Location = new System.Drawing.Point(81, 189);
            this.AboneDataGrid.Name = "AboneDataGrid";
            this.AboneDataGrid.Size = new System.Drawing.Size(694, 206);
            this.AboneDataGrid.TabIndex = 3;
            this.AboneDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aboneBindingSource
            // 
            this.aboneBindingSource.DataSource = typeof(WP_SuAboneTakip.Abone);
            // 
            // aboneIDDataGridViewTextBoxColumn
            // 
            this.aboneIDDataGridViewTextBoxColumn.DataPropertyName = "Abone_ID";
            this.aboneIDDataGridViewTextBoxColumn.HeaderText = "Abone_ID";
            this.aboneIDDataGridViewTextBoxColumn.Name = "aboneIDDataGridViewTextBoxColumn";
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "İsim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "İsim";
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // eskiBorcDataGridViewTextBoxColumn
            // 
            this.eskiBorcDataGridViewTextBoxColumn.DataPropertyName = "EskiBorc";
            this.eskiBorcDataGridViewTextBoxColumn.HeaderText = "EskiBorc";
            this.eskiBorcDataGridViewTextBoxColumn.Name = "eskiBorcDataGridViewTextBoxColumn";
            // 
            // AboneSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 436);
            this.Controls.Add(this.AboneDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "AboneSorgula";
            this.Text = "AboneSorgula";
            this.Load += new System.EventHandler(this.AboneSorgula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AboneDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AboneDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eskiBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aboneBindingSource;
    }
}