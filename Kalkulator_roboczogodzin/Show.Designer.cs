﻿namespace Kalkulator_roboczogodzin
{
    partial class Show
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
            this.return_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zleceniodawcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerKatalogowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przewidywanyCzasPracyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRealizacjiKlientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRealizacjiFinalnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodajzlecenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_zlecenDataSet = new Kalkulator_roboczogodzin.Baza_zlecenDataSet();
            this.dodaj_zlecenieTableAdapter = new Kalkulator_roboczogodzin.Baza_zlecenDataSetTableAdapters.Dodaj_zlecenieTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajzlecenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_zlecenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(925, 381);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(75, 23);
            this.return_button.TabIndex = 0;
            this.return_button.Text = "Powrót";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.zleceniodawcaDataGridViewTextBoxColumn,
            this.numerKatalogowyDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.przewidywanyCzasPracyDataGridViewTextBoxColumn,
            this.dataRealizacjiKlientDataGridViewTextBoxColumn,
            this.dataRealizacjiFinalnaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dodajzlecenieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 44;
            this.dataGridView1.Size = new System.Drawing.Size(836, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // zleceniodawcaDataGridViewTextBoxColumn
            // 
            this.zleceniodawcaDataGridViewTextBoxColumn.DataPropertyName = "Zleceniodawca";
            this.zleceniodawcaDataGridViewTextBoxColumn.HeaderText = "Zleceniodawca";
            this.zleceniodawcaDataGridViewTextBoxColumn.Name = "zleceniodawcaDataGridViewTextBoxColumn";
            this.zleceniodawcaDataGridViewTextBoxColumn.Width = 105;
            // 
            // numerKatalogowyDataGridViewTextBoxColumn
            // 
            this.numerKatalogowyDataGridViewTextBoxColumn.DataPropertyName = "NumerKatalogowy";
            this.numerKatalogowyDataGridViewTextBoxColumn.HeaderText = "NumerKatalogowy";
            this.numerKatalogowyDataGridViewTextBoxColumn.Name = "numerKatalogowyDataGridViewTextBoxColumn";
            this.numerKatalogowyDataGridViewTextBoxColumn.Width = 118;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.Width = 65;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 53;
            // 
            // przewidywanyCzasPracyDataGridViewTextBoxColumn
            // 
            this.przewidywanyCzasPracyDataGridViewTextBoxColumn.DataPropertyName = "PrzewidywanyCzasPracy";
            this.przewidywanyCzasPracyDataGridViewTextBoxColumn.HeaderText = "PrzewidywanyCzasPracy";
            this.przewidywanyCzasPracyDataGridViewTextBoxColumn.Name = "przewidywanyCzasPracyDataGridViewTextBoxColumn";
            this.przewidywanyCzasPracyDataGridViewTextBoxColumn.Width = 149;
            // 
            // dataRealizacjiKlientDataGridViewTextBoxColumn
            // 
            this.dataRealizacjiKlientDataGridViewTextBoxColumn.DataPropertyName = "DataRealizacjiKlient";
            this.dataRealizacjiKlientDataGridViewTextBoxColumn.HeaderText = "DataRealizacjiKlient";
            this.dataRealizacjiKlientDataGridViewTextBoxColumn.Name = "dataRealizacjiKlientDataGridViewTextBoxColumn";
            this.dataRealizacjiKlientDataGridViewTextBoxColumn.Width = 126;
            // 
            // dataRealizacjiFinalnaDataGridViewTextBoxColumn
            // 
            this.dataRealizacjiFinalnaDataGridViewTextBoxColumn.DataPropertyName = "DataRealizacjiFinalna";
            this.dataRealizacjiFinalnaDataGridViewTextBoxColumn.HeaderText = "DataRealizacjiFinalna";
            this.dataRealizacjiFinalnaDataGridViewTextBoxColumn.Name = "dataRealizacjiFinalnaDataGridViewTextBoxColumn";
            this.dataRealizacjiFinalnaDataGridViewTextBoxColumn.Width = 134;
            // 
            // dodajzlecenieBindingSource
            // 
            this.dodajzlecenieBindingSource.DataMember = "Dodaj_zlecenie";
            this.dodajzlecenieBindingSource.DataSource = this.baza_zlecenDataSet;
            // 
            // baza_zlecenDataSet
            // 
            this.baza_zlecenDataSet.DataSetName = "Baza_zlecenDataSet";
            this.baza_zlecenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dodaj_zlecenieTableAdapter
            // 
            this.dodaj_zlecenieTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szukaj zleceniodawcy";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1026, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 538);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.return_button);
            this.Name = "Show";
            this.Text = "Show";
            this.Load += new System.EventHandler(this.Show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajzlecenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_zlecenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Baza_zlecenDataSet baza_zlecenDataSet;
        private System.Windows.Forms.BindingSource dodajzlecenieBindingSource;
        private Baza_zlecenDataSetTableAdapters.Dodaj_zlecenieTableAdapter dodaj_zlecenieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zleceniodawcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerKatalogowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn przewidywanyCzasPracyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRealizacjiKlientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRealizacjiFinalnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}