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
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lCurrentTime = new System.Windows.Forms.Label();
            this.cbSystem = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSummarize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbPlan = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(330, 12);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(84, 21);
            this.cbTable.TabIndex = 4;
            this.cbTable.Text = "Tisch-Wahl";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(244, 13);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(80, 20);
            this.dtpStartTime.TabIndex = 9;
            this.dtpStartTime.Value = new System.DateTime(2017, 3, 24, 18, 0, 0, 0);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(193, 16);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(48, 13);
            this.lblStart.TabIndex = 11;
            this.lblStart.Text = "Startzeit:";
            // 
            // lCurrentTime
            // 
            this.lCurrentTime.AutoSize = true;
            this.lCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurrentTime.Location = new System.Drawing.Point(507, 625);
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
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(364, 43);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = ".";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSummarize
            // 
            this.btnSummarize.FlatAppearance.BorderSize = 0;
            this.btnSummarize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSummarize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSummarize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummarize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummarize.Image = global::NT_Verwaltung.Properties.Resources.document_export;
            this.btnSummarize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSummarize.Location = new System.Drawing.Point(193, 33);
            this.btnSummarize.Name = "btnSummarize";
            this.btnSummarize.Size = new System.Drawing.Size(165, 35);
            this.btnSummarize.TabIndex = 22;
            this.btnSummarize.Text = "Tagesabschluss";
            this.btnSummarize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSummarize.UseVisualStyleBackColor = true;
            this.btnSummarize.Click += new System.EventHandler(this.btnSummarize_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::NT_Verwaltung.Properties.Resources.view_remove;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(100, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 55);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Austragen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbPlan
            // 
            this.pbPlan.Location = new System.Drawing.Point(491, 150);
            this.pbPlan.Name = "pbPlan";
            this.pbPlan.Size = new System.Drawing.Size(156, 226);
            this.pbPlan.TabIndex = 19;
            this.pbPlan.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(480, 43);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(177, 101);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::NT_Verwaltung.Properties.Resources.task_new;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.Location = new System.Drawing.Point(7, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Eintragen";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.cmdRundenstart_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 73);
            this.dgvList.Name = "dgvList";
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(462, 577);
            this.dgvList.TabIndex = 23;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 662);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnSummarize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbPlan);
            this.Controls.Add(this.cbSystem);
            this.Controls.Add(this.lCurrentTime);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NT-Verwaltungsprogramm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lCurrentTime;
        private System.Windows.Forms.ComboBox cbSystem;
		private System.Windows.Forms.PictureBox pbPlan;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSummarize;
        private System.Windows.Forms.DataGridView dgvList;
    }
}

