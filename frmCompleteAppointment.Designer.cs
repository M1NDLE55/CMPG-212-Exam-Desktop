namespace Desktop_44905165
{
    partial class frmCompleteAppointment
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
            this.lblInvoice = new MaterialSkin.Controls.MaterialLabel();
            this.cardInvoice = new MaterialSkin.Controls.MaterialCard();
            this.rtbInvoice = new System.Windows.Forms.RichTextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnComplete = new MaterialSkin.Controls.MaterialButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.cardInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Depth = 0;
            this.lblInvoice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInvoice.Location = new System.Drawing.Point(17, 38);
            this.lblInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(51, 19);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Invoice";
            // 
            // cardInvoice
            // 
            this.cardInvoice.AutoScroll = true;
            this.cardInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardInvoice.Controls.Add(this.rtbInvoice);
            this.cardInvoice.Depth = 0;
            this.cardInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardInvoice.Location = new System.Drawing.Point(20, 71);
            this.cardInvoice.Margin = new System.Windows.Forms.Padding(14);
            this.cardInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardInvoice.Name = "cardInvoice";
            this.cardInvoice.Padding = new System.Windows.Forms.Padding(14);
            this.cardInvoice.Size = new System.Drawing.Size(339, 288);
            this.cardInvoice.TabIndex = 1;
            // 
            // rtbInvoice
            // 
            this.rtbInvoice.BackColor = System.Drawing.Color.White;
            this.rtbInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInvoice.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInvoice.Location = new System.Drawing.Point(55, 17);
            this.rtbInvoice.Name = "rtbInvoice";
            this.rtbInvoice.ReadOnly = true;
            this.rtbInvoice.Size = new System.Drawing.Size(267, 254);
            this.rtbInvoice.TabIndex = 0;
            this.rtbInvoice.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(20, 379);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(339, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Invoice";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.AutoSize = false;
            this.btnComplete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnComplete.Depth = 0;
            this.btnComplete.HighEmphasis = true;
            this.btnComplete.Icon = null;
            this.btnComplete.Location = new System.Drawing.Point(20, 427);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnComplete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnComplete.Size = new System.Drawing.Size(339, 36);
            this.btnComplete.TabIndex = 3;
            this.btnComplete.Text = "Complete Appointment";
            this.btnComplete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnComplete.UseAccentColor = true;
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            // 
            // frmCompleteAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 481);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cardInvoice);
            this.Controls.Add(this.lblInvoice);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frmCompleteAppointment";
            this.Padding = new System.Windows.Forms.Padding(14, 38, 14, 14);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Appointment";
            this.Load += new System.EventHandler(this.frmCompleteAppointment_Load);
            this.cardInvoice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblInvoice;
        private MaterialSkin.Controls.MaterialCard cardInvoice;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnComplete;
        private System.Windows.Forms.RichTextBox rtbInvoice;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}