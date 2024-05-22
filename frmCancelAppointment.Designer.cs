namespace Desktop_44905165
{
    partial class frmCancelAppointment
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
            this.lblReason = new MaterialSkin.Controls.MaterialLabel();
            this.cardReason = new MaterialSkin.Controls.MaterialCard();
            this.btnConfirm = new MaterialSkin.Controls.MaterialButton();
            this.rdoCancelled = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoNoShow = new MaterialSkin.Controls.MaterialRadioButton();
            this.cardReason.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Depth = 0;
            this.lblReason.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReason.Location = new System.Drawing.Point(17, 38);
            this.lblReason.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(170, 19);
            this.lblReason.TabIndex = 0;
            this.lblReason.Text = "Reason for Cancellation";
            // 
            // cardReason
            // 
            this.cardReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardReason.Controls.Add(this.rdoNoShow);
            this.cardReason.Controls.Add(this.rdoCancelled);
            this.cardReason.Depth = 0;
            this.cardReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardReason.Location = new System.Drawing.Point(20, 71);
            this.cardReason.Margin = new System.Windows.Forms.Padding(14);
            this.cardReason.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardReason.Name = "cardReason";
            this.cardReason.Padding = new System.Windows.Forms.Padding(14);
            this.cardReason.Size = new System.Drawing.Size(263, 65);
            this.cardReason.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = false;
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirm.Depth = 0;
            this.btnConfirm.HighEmphasis = true;
            this.btnConfirm.Icon = null;
            this.btnConfirm.Location = new System.Drawing.Point(20, 156);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirm.Size = new System.Drawing.Size(263, 36);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirm.UseAccentColor = true;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // rdoCancelled
            // 
            this.rdoCancelled.AutoSize = true;
            this.rdoCancelled.Depth = 0;
            this.rdoCancelled.Location = new System.Drawing.Point(14, 14);
            this.rdoCancelled.Margin = new System.Windows.Forms.Padding(0);
            this.rdoCancelled.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoCancelled.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoCancelled.Name = "rdoCancelled";
            this.rdoCancelled.Ripple = true;
            this.rdoCancelled.Size = new System.Drawing.Size(104, 37);
            this.rdoCancelled.TabIndex = 0;
            this.rdoCancelled.TabStop = true;
            this.rdoCancelled.Text = "Cancelled";
            this.rdoCancelled.UseVisualStyleBackColor = true;
            // 
            // rdoNoShow
            // 
            this.rdoNoShow.AutoSize = true;
            this.rdoNoShow.Depth = 0;
            this.rdoNoShow.Location = new System.Drawing.Point(142, 14);
            this.rdoNoShow.Margin = new System.Windows.Forms.Padding(0);
            this.rdoNoShow.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoNoShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoNoShow.Name = "rdoNoShow";
            this.rdoNoShow.Ripple = true;
            this.rdoNoShow.Size = new System.Drawing.Size(97, 37);
            this.rdoNoShow.TabIndex = 1;
            this.rdoNoShow.TabStop = true;
            this.rdoNoShow.Text = "No show";
            this.rdoNoShow.UseVisualStyleBackColor = true;
            // 
            // frmCancelAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 211);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cardReason);
            this.Controls.Add(this.lblReason);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frmCancelAppointment";
            this.Padding = new System.Windows.Forms.Padding(14, 38, 14, 14);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Appointment";
            this.cardReason.ResumeLayout(false);
            this.cardReason.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblReason;
        private MaterialSkin.Controls.MaterialCard cardReason;
        private MaterialSkin.Controls.MaterialRadioButton rdoNoShow;
        private MaterialSkin.Controls.MaterialRadioButton rdoCancelled;
        private MaterialSkin.Controls.MaterialButton btnConfirm;
    }
}