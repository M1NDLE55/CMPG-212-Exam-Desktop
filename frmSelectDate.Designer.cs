namespace Desktop_44905165
{
    partial class frmSelectDate
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
            this.cardDate = new MaterialSkin.Controls.MaterialCard();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.btnConfirm = new MaterialSkin.Controls.MaterialButton();
            this.lblTime = new MaterialSkin.Controls.MaterialLabel();
            this.cardTime = new MaterialSkin.Controls.MaterialCard();
            this.cmbTime = new MaterialSkin.Controls.MaterialComboBox();
            this.cardNewDateTime = new MaterialSkin.Controls.MaterialCard();
            this.lblNewDateTime = new MaterialSkin.Controls.MaterialLabel();
            this.lblDateTimeHeading = new MaterialSkin.Controls.MaterialLabel();
            this.cardDate.SuspendLayout();
            this.cardTime.SuspendLayout();
            this.cardNewDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardDate
            // 
            this.cardDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardDate.Controls.Add(this.calDate);
            this.cardDate.Depth = 0;
            this.cardDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardDate.Location = new System.Drawing.Point(20, 71);
            this.cardDate.Margin = new System.Windows.Forms.Padding(14);
            this.cardDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardDate.Name = "cardDate";
            this.cardDate.Padding = new System.Windows.Forms.Padding(14);
            this.cardDate.Size = new System.Drawing.Size(274, 207);
            this.cardDate.TabIndex = 0;
            // 
            // calDate
            // 
            this.calDate.Location = new System.Drawing.Point(23, 23);
            this.calDate.MaxSelectionCount = 1;
            this.calDate.Name = "calDate";
            this.calDate.TabIndex = 0;
            this.calDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calDate_DateChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.Location = new System.Drawing.Point(17, 38);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 19);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = false;
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirm.Depth = 0;
            this.btnConfirm.HighEmphasis = true;
            this.btnConfirm.Icon = null;
            this.btnConfirm.Location = new System.Drawing.Point(20, 311);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirm.Size = new System.Drawing.Size(576, 36);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirm.UseAccentColor = true;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Depth = 0;
            this.lblTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTime.Location = new System.Drawing.Point(319, 38);
            this.lblTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 19);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // cardTime
            // 
            this.cardTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardTime.Controls.Add(this.cmbTime);
            this.cardTime.Depth = 0;
            this.cardTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardTime.Location = new System.Drawing.Point(322, 71);
            this.cardTime.Margin = new System.Windows.Forms.Padding(14);
            this.cardTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardTime.Name = "cardTime";
            this.cardTime.Padding = new System.Windows.Forms.Padding(14);
            this.cardTime.Size = new System.Drawing.Size(274, 84);
            this.cardTime.TabIndex = 4;
            // 
            // cmbTime
            // 
            this.cmbTime.AutoResize = false;
            this.cmbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTime.Depth = 0;
            this.cmbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTime.DropDownHeight = 174;
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.DropDownWidth = 121;
            this.cmbTime.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.IntegralHeight = false;
            this.cmbTime.ItemHeight = 43;
            this.cmbTime.Location = new System.Drawing.Point(23, 17);
            this.cmbTime.MaxDropDownItems = 4;
            this.cmbTime.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(227, 49);
            this.cmbTime.StartIndex = 0;
            this.cmbTime.TabIndex = 0;
            this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged);
            // 
            // cardNewDateTime
            // 
            this.cardNewDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardNewDateTime.Controls.Add(this.lblNewDateTime);
            this.cardNewDateTime.Depth = 0;
            this.cardNewDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardNewDateTime.Location = new System.Drawing.Point(322, 202);
            this.cardNewDateTime.Margin = new System.Windows.Forms.Padding(14);
            this.cardNewDateTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardNewDateTime.Name = "cardNewDateTime";
            this.cardNewDateTime.Padding = new System.Windows.Forms.Padding(14);
            this.cardNewDateTime.Size = new System.Drawing.Size(274, 76);
            this.cardNewDateTime.TabIndex = 5;
            // 
            // lblNewDateTime
            // 
            this.lblNewDateTime.Depth = 0;
            this.lblNewDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewDateTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNewDateTime.Location = new System.Drawing.Point(14, 14);
            this.lblNewDateTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewDateTime.Name = "lblNewDateTime";
            this.lblNewDateTime.Size = new System.Drawing.Size(246, 48);
            this.lblNewDateTime.TabIndex = 0;
            this.lblNewDateTime.Text = "DateTime";
            this.lblNewDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTimeHeading
            // 
            this.lblDateTimeHeading.AutoSize = true;
            this.lblDateTimeHeading.Depth = 0;
            this.lblDateTimeHeading.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDateTimeHeading.Location = new System.Drawing.Point(319, 169);
            this.lblDateTimeHeading.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDateTimeHeading.Name = "lblDateTimeHeading";
            this.lblDateTimeHeading.Size = new System.Drawing.Size(134, 19);
            this.lblDateTimeHeading.TabIndex = 6;
            this.lblDateTimeHeading.Text = "New Booking Time";
            // 
            // frmSelectDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(617, 369);
            this.Controls.Add(this.lblDateTimeHeading);
            this.Controls.Add(this.cardNewDateTime);
            this.Controls.Add(this.cardTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cardDate);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frmSelectDate";
            this.Padding = new System.Windows.Forms.Padding(14, 38, 14, 14);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Date";
            this.Load += new System.EventHandler(this.frmSelectDate_Load);
            this.cardDate.ResumeLayout(false);
            this.cardTime.ResumeLayout(false);
            this.cardNewDateTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardDate;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private System.Windows.Forms.MonthCalendar calDate;
        private MaterialSkin.Controls.MaterialButton btnConfirm;
        private MaterialSkin.Controls.MaterialLabel lblTime;
        private MaterialSkin.Controls.MaterialCard cardTime;
        private MaterialSkin.Controls.MaterialComboBox cmbTime;
        private MaterialSkin.Controls.MaterialCard cardNewDateTime;
        private MaterialSkin.Controls.MaterialLabel lblDateTimeHeading;
        private MaterialSkin.Controls.MaterialLabel lblNewDateTime;
    }
}