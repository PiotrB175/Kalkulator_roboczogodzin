namespace Kalkulator_roboczogodzin
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_zleceniodawca = new System.Windows.Forms.TextBox();
            this.txt_numer_zamowienia = new System.Windows.Forms.TextBox();
            this.txt_nazwa = new System.Windows.Forms.TextBox();
            this.txt_opis = new System.Windows.Forms.TextBox();
            this.txt_data_realizacji_zleceniodawca = new System.Windows.Forms.TextBox();
            this.txt_przewidywany_czas_pracy = new System.Windows.Forms.TextBox();
            this.txt_data_realizacji_finalna = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.appData = new Kalkulator_roboczogodzin.AppData();
            this.dodajzlecenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodaj_zlecenieTableAdapter = new Kalkulator_roboczogodzin.AppDataTableAdapters.Dodaj_zlecenieTableAdapter();
            this.dodajzlecenieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajzlecenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajzlecenieBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(208, 351);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(100, 20);
            this.return_button.TabIndex = 0;
            this.return_button.Text = "Powrót";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zleceniodawca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numer zamówienia (zleceniodawcy)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data realizacji (zleceniodawca)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Przewidywany czas pracy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data realizacji ( finalna)";
            // 
            // txt_zleceniodawca
            // 
            this.txt_zleceniodawca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dodajzlecenieBindingSource, "Zleceniodawca", true));
            this.txt_zleceniodawca.Location = new System.Drawing.Point(208, 12);
            this.txt_zleceniodawca.Name = "txt_zleceniodawca";
            this.txt_zleceniodawca.Size = new System.Drawing.Size(100, 20);
            this.txt_zleceniodawca.TabIndex = 8;
            // 
            // txt_numer_zamowienia
            // 
            this.txt_numer_zamowienia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dodajzlecenieBindingSource, "Numer zamówienia (zleceniodawcy)", true));
            this.txt_numer_zamowienia.Location = new System.Drawing.Point(208, 52);
            this.txt_numer_zamowienia.Name = "txt_numer_zamowienia";
            this.txt_numer_zamowienia.Size = new System.Drawing.Size(100, 20);
            this.txt_numer_zamowienia.TabIndex = 9;
            // 
            // txt_nazwa
            // 
            this.txt_nazwa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dodajzlecenieBindingSource, "Nazwa", true));
            this.txt_nazwa.Location = new System.Drawing.Point(208, 92);
            this.txt_nazwa.Name = "txt_nazwa";
            this.txt_nazwa.Size = new System.Drawing.Size(100, 20);
            this.txt_nazwa.TabIndex = 10;
            // 
            // txt_opis
            // 
            this.txt_opis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dodajzlecenieBindingSource, "Opis", true));
            this.txt_opis.Location = new System.Drawing.Point(208, 132);
            this.txt_opis.Name = "txt_opis";
            this.txt_opis.Size = new System.Drawing.Size(100, 20);
            this.txt_opis.TabIndex = 11;
            // 
            // txt_data_realizacji_zleceniodawca
            // 
            this.txt_data_realizacji_zleceniodawca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dodajzlecenieBindingSource, "Data realizacji (klient)", true));
            this.txt_data_realizacji_zleceniodawca.Location = new System.Drawing.Point(208, 172);
            this.txt_data_realizacji_zleceniodawca.Name = "txt_data_realizacji_zleceniodawca";
            this.txt_data_realizacji_zleceniodawca.Size = new System.Drawing.Size(100, 20);
            this.txt_data_realizacji_zleceniodawca.TabIndex = 12;
            this.txt_data_realizacji_zleceniodawca.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_przewidywany_czas_pracy
            // 
            this.txt_przewidywany_czas_pracy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dodajzlecenieBindingSource, "Przewidywany czas pracy", true));
            this.txt_przewidywany_czas_pracy.Location = new System.Drawing.Point(208, 212);
            this.txt_przewidywany_czas_pracy.Name = "txt_przewidywany_czas_pracy";
            this.txt_przewidywany_czas_pracy.Size = new System.Drawing.Size(100, 20);
            this.txt_przewidywany_czas_pracy.TabIndex = 13;
            // 
            // txt_data_realizacji_finalna
            // 
            this.txt_data_realizacji_finalna.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dodajzlecenieBindingSource, "Data realizacji (finalna)", true));
            this.txt_data_realizacji_finalna.Location = new System.Drawing.Point(208, 252);
            this.txt_data_realizacji_finalna.Name = "txt_data_realizacji_finalna";
            this.txt_data_realizacji_finalna.Size = new System.Drawing.Size(100, 20);
            this.txt_data_realizacji_finalna.TabIndex = 14;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(208, 325);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 20);
            this.save_button.TabIndex = 15;
            this.save_button.Text = "Zapisz";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dodajzlecenieBindingSource
            // 
            this.dodajzlecenieBindingSource.DataMember = "Dodaj_zlecenie";
            this.dodajzlecenieBindingSource.DataSource = this.appData;
            // 
            // dodaj_zlecenieTableAdapter
            // 
            this.dodaj_zlecenieTableAdapter.ClearBeforeFill = true;
            // 
            // dodajzlecenieBindingSource1
            // 
            this.dodajzlecenieBindingSource1.DataMember = "Dodaj_zlecenie";
            this.dodajzlecenieBindingSource1.DataSource = this.appData;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 391);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.txt_data_realizacji_finalna);
            this.Controls.Add(this.txt_przewidywany_czas_pracy);
            this.Controls.Add(this.txt_data_realizacji_zleceniodawca);
            this.Controls.Add(this.txt_opis);
            this.Controls.Add(this.txt_nazwa);
            this.Controls.Add(this.txt_numer_zamowienia);
            this.Controls.Add(this.txt_zleceniodawca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_button);
            this.Name = "Add";
            this.Text = "Dodaj";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajzlecenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajzlecenieBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_zleceniodawca;
        private System.Windows.Forms.TextBox txt_numer_zamowienia;
        private System.Windows.Forms.TextBox txt_nazwa;
        private System.Windows.Forms.TextBox txt_opis;
        private System.Windows.Forms.TextBox txt_data_realizacji_zleceniodawca;
        private System.Windows.Forms.TextBox txt_przewidywany_czas_pracy;
        private System.Windows.Forms.TextBox txt_data_realizacji_finalna;
        private System.Windows.Forms.Button save_button;
        private AppData appData;
        private System.Windows.Forms.BindingSource dodajzlecenieBindingSource;
        private AppDataTableAdapters.Dodaj_zlecenieTableAdapter dodaj_zlecenieTableAdapter;
        private System.Windows.Forms.BindingSource dodajzlecenieBindingSource1;
    }
}