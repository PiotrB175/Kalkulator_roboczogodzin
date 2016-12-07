namespace Kalkulator_roboczogodzin
{
    partial class Home
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
            this.Exit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.show_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(12, 283);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(160, 40);
            this.Exit_button.TabIndex = 0;
            this.Exit_button.Text = "Wyście";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_button.Location = new System.Drawing.Point(12, 12);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(160, 40);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Dodaj";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(12, 58);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(160, 40);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "Edytuj";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(12, 104);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(160, 40);
            this.show_button.TabIndex = 4;
            this.show_button.Text = "Podgląd";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 335);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Exit_button);
            this.Name = "Home";
            this.Text = "Kalkulator roboczogodzin";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button show_button;
    }
}

