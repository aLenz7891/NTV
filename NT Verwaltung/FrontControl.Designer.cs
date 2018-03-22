namespace NT_Verwaltung
{
    partial class FrontControl
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnOpenVerwaltung = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(14, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(177, 101);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // btnOpenVerwaltung
            // 
            this.btnOpenVerwaltung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenVerwaltung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenVerwaltung.Image = global::NT_Verwaltung.Properties.Resources.appointment_new;
            this.btnOpenVerwaltung.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenVerwaltung.Location = new System.Drawing.Point(14, 119);
            this.btnOpenVerwaltung.Name = "btnOpenVerwaltung";
            this.btnOpenVerwaltung.Size = new System.Drawing.Size(84, 52);
            this.btnOpenVerwaltung.TabIndex = 0;
            this.btnOpenVerwaltung.Text = "Verwaltung";
            this.btnOpenVerwaltung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenVerwaltung.UseVisualStyleBackColor = true;
            this.btnOpenVerwaltung.Click += new System.EventHandler(this.btnOpenVerwaltung_Click);
            // 
            // FrontControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 262);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnOpenVerwaltung);
            this.Name = "FrontControl";
            this.Text = "NT-Tools";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenVerwaltung;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}