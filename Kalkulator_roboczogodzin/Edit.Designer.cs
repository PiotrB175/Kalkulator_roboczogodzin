namespace Kalkulator_roboczogodzin
{
    partial class Edit
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
            this.delete_button = new System.Windows.Forms.Button();
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
            this.overwrite_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajzlecenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_zlecenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(883, 343);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(75, 23);
            this.return_button.TabIndex = 0;
            this.return_button.Text = "Powrót";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(883, 314);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Usuń";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
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
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(834, 354);
            this.dataGridView1.TabIndex = 2;
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
            // overwrite_button
            // 
            this.overwrite_button.Location = new System.Drawing.Point(883, 285);
            this.overwrite_button.Name = "overwrite_button";
            this.overwrite_button.Size = new System.Drawing.Size(75, 23);
            this.overwrite_button.TabIndex = 3;
            this.overwrite_button.Text = "Nadpisz";
            this.overwrite_button.UseVisualStyleBackColor = true;
            this.overwrite_button.Click += new System.EventHandler(this.overwrite_button_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 378);
            this.Controls.Add(this.overwrite_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.return_button);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajzlecenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_zlecenDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button delete_button;
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
        private System.Windows.Forms.Button overwrite_button;
    }
}