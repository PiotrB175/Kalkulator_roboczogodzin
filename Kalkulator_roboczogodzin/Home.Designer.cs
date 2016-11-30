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
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(560, 403);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 456);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Exit_button);
            this.Name = "Home";
            this.Text = "Kalkulator roboczogodzin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button add_button;
    }
}

