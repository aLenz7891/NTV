namespace NT_Verwaltung
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
			this.components = new System.ComponentModel.Container();
			this.cbTable = new System.Windows.Forms.ComboBox();
			this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
			this.lblStart = new System.Windows.Forms.Label();
			this.lvList = new System.Windows.Forms.ListView();
			this.lCurrentTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.cbSystem = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbLength = new System.Windows.Forms.NumericUpDown();
			this.lblStatus = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pbPlan = new System.Windows.Forms.PictureBox();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.btnStart = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tbLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPlan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// cbTable
			// 
			this.cbTable.FormattingEnabled = true;
			this.cbTable.Location = new System.Drawing.Point(198, 36);
			this.cbTable.Name = "cbTable";
			this.cbTable.Size = new System.Drawing.Size(131, 21);
			this.cbTable.TabIndex = 4;
			this.cbTable.Text = "Tisch-Wahl";
			// 
			// dtpStartTime
			// 
			this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpStartTime.Location = new System.Drawing.Point(249, 13);
			this.dtpStartTime.Name = "dtpStartTime";
			this.dtpStartTime.ShowUpDown = true;
			this.dtpStartTime.Size = new System.Drawing.Size(80, 20);
			this.dtpStartTime.TabIndex = 9;
			this.dtpStartTime.Value = new System.DateTime(2017, 3, 24, 18, 0, 0, 0);
			// 
			// lblStart
			// 
			this.lblStart.AutoSize = true;
			this.lblStart.Location = new System.Drawing.Point(198, 16);
			this.lblStart.Name = "lblStart";
			this.lblStart.Size = new System.Drawing.Size(48, 13);
			this.lblStart.TabIndex = 11;
			this.lblStart.Text = "Startzeit:";
			// 
			// lvList
			// 
			this.lvList.GridLines = true;
			this.lvList.HoverSelection = true;
			this.lvList.Location = new System.Drawing.Point(12, 68);
			this.lvList.Name = "lvList";
			this.lvList.Size = new System.Drawing.Size(877, 590);
			this.lvList.TabIndex = 12;
			this.lvList.UseCompatibleStateImageBehavior = false;
			this.lvList.View = System.Windows.Forms.View.Details;
			// 
			// lCurrentTime
			// 
			this.lCurrentTime.AutoSize = true;
			this.lCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lCurrentTime.Location = new System.Drawing.Point(920, 625);
			this.lCurrentTime.Name = "lCurrentTime";
			this.lCurrentTime.Size = new System.Drawing.Size(135, 25);
			this.lCurrentTime.TabIndex = 14;
			this.lCurrentTime.Text = "lCurrentTime";
			// 
			// cbSystem
			// 
			this.cbSystem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbSystem.FormattingEnabled = true;
			this.cbSystem.Location = new System.Drawing.Point(420, 12);
			this.cbSystem.Name = "cbSystem";
			this.cbSystem.Size = new System.Drawing.Size(237, 21);
			this.cbSystem.TabIndex = 15;
			this.cbSystem.Text = "System Wählen";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(335, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Dauer:";
			// 
			// tbLength
			// 
			this.tbLength.Location = new System.Drawing.Point(377, 13);
			this.tbLength.Name = "tbLength";
			this.tbLength.Size = new System.Drawing.Size(37, 20);
			this.tbLength.TabIndex = 18;
			this.tbLength.ThousandsSeparator = true;
			this.tbLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(337, 41);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(10, 13);
			this.lblStatus.TabIndex = 20;
			this.lblStatus.Text = ".";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = global::NT_Verwaltung.Properties.Resources.document_export;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.Location = new System.Drawing.Point(757, 7);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 55);
			this.button2.TabIndex = 22;
			this.button2.Text = "Tagesabschluss";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = global::NT_Verwaltung.Properties.Resources.view_remove;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(105, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 55);
			this.button1.TabIndex = 21;
			this.button1.Text = "Austragen";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// pbPlan
			// 
			this.pbPlan.Location = new System.Drawing.Point(905, 114);
			this.pbPlan.Name = "pbPlan";
			this.pbPlan.Size = new System.Drawing.Size(156, 226);
			this.pbPlan.TabIndex = 19;
			this.pbPlan.TabStop = false;
			// 
			// pbLogo
			// 
			this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbLogo.InitialImage = null;
			this.pbLogo.Location = new System.Drawing.Point(895, 7);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(177, 101);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogo.TabIndex = 5;
			this.pbLogo.TabStop = false;
			// 
			// btnStart
			// 
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Image = global::NT_Verwaltung.Properties.Resources.task_new;
			this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnStart.Location = new System.Drawing.Point(12, 7);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(87, 55);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Eintragen";
			this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.cmdRundenstart_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 662);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.pbPlan);
			this.Controls.Add(this.tbLength);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbSystem);
			this.Controls.Add(this.lCurrentTime);
			this.Controls.Add(this.lvList);
			this.Controls.Add(this.lblStart);
			this.Controls.Add(this.dtpStartTime);
			this.Controls.Add(this.pbLogo);
			this.Controls.Add(this.cbTable);
			this.Controls.Add(this.btnStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NT Verwaltung";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.tbLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPlan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.Label lCurrentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbSystem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown tbLength;
		private System.Windows.Forms.PictureBox pbPlan;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

