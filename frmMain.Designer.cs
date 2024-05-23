namespace Desktop_44905165
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabViewAppointments = new System.Windows.Forms.TabPage();
            this.lblActions = new MaterialSkin.Controls.MaterialLabel();
            this.lblAppointments = new MaterialSkin.Controls.MaterialLabel();
            this.cardActions = new MaterialSkin.Controls.MaterialCard();
            this.btnRemove = new MaterialSkin.Controls.MaterialButton();
            this.btnMove = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnComplete = new MaterialSkin.Controls.MaterialButton();
            this.cardGV = new MaterialSkin.Controls.MaterialCard();
            this.rdoNone = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoOpen = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoNoShow = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoCancelled = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoCompleted = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblFilter = new MaterialSkin.Controls.MaterialLabel();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.tabCreateAppointment = new System.Windows.Forms.TabPage();
            this.tabRegiser = new System.Windows.Forms.TabPage();
            this.materialTab.SuspendLayout();
            this.tabViewAppointments.SuspendLayout();
            this.cardActions.SuspendLayout();
            this.cardGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTab
            // 
            this.materialTab.Controls.Add(this.tabViewAppointments);
            this.materialTab.Controls.Add(this.tabCreateAppointment);
            this.materialTab.Controls.Add(this.tabRegiser);
            this.materialTab.Depth = 0;
            this.materialTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTab.Location = new System.Drawing.Point(0, 64);
            this.materialTab.Margin = new System.Windows.Forms.Padding(0);
            this.materialTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTab.Multiline = true;
            this.materialTab.Name = "materialTab";
            this.materialTab.Padding = new System.Drawing.Point(0, 0);
            this.materialTab.SelectedIndex = 0;
            this.materialTab.Size = new System.Drawing.Size(929, 518);
            this.materialTab.TabIndex = 0;
            // 
            // tabViewAppointments
            // 
            this.tabViewAppointments.BackColor = System.Drawing.SystemColors.Control;
            this.tabViewAppointments.Controls.Add(this.lblActions);
            this.tabViewAppointments.Controls.Add(this.lblAppointments);
            this.tabViewAppointments.Controls.Add(this.cardActions);
            this.tabViewAppointments.Controls.Add(this.cardGV);
            this.tabViewAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabViewAppointments.Margin = new System.Windows.Forms.Padding(0);
            this.tabViewAppointments.Name = "tabViewAppointments";
            this.tabViewAppointments.Size = new System.Drawing.Size(921, 492);
            this.tabViewAppointments.TabIndex = 0;
            this.tabViewAppointments.Text = "View Appointments";
            this.tabViewAppointments.Enter += new System.EventHandler(this.tabViewAppointments_Enter);
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Depth = 0;
            this.lblActions.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblActions.Location = new System.Drawing.Point(18, 360);
            this.lblActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(54, 19);
            this.lblActions.TabIndex = 6;
            this.lblActions.Text = "Actions";
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Depth = 0;
            this.lblAppointments.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAppointments.Location = new System.Drawing.Point(18, 19);
            this.lblAppointments.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(100, 19);
            this.lblAppointments.TabIndex = 4;
            this.lblAppointments.Text = "Appointments";
            // 
            // cardActions
            // 
            this.cardActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardActions.Controls.Add(this.btnRemove);
            this.cardActions.Controls.Add(this.btnMove);
            this.cardActions.Controls.Add(this.btnCancel);
            this.cardActions.Controls.Add(this.btnComplete);
            this.cardActions.Depth = 0;
            this.cardActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardActions.Location = new System.Drawing.Point(21, 393);
            this.cardActions.Margin = new System.Windows.Forms.Padding(14, 14, 14, 0);
            this.cardActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardActions.Name = "cardActions";
            this.cardActions.Padding = new System.Windows.Forms.Padding(14);
            this.cardActions.Size = new System.Drawing.Size(881, 74);
            this.cardActions.TabIndex = 7;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = false;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemove.Depth = 0;
            this.btnRemove.HighEmphasis = true;
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(648, 20);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemove.Size = new System.Drawing.Size(170, 36);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemove.UseAccentColor = false;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMove
            // 
            this.btnMove.AutoSize = false;
            this.btnMove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMove.Depth = 0;
            this.btnMove.HighEmphasis = true;
            this.btnMove.Icon = null;
            this.btnMove.Location = new System.Drawing.Point(69, 20);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMove.Name = "btnMove";
            this.btnMove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMove.Size = new System.Drawing.Size(170, 36);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "Move";
            this.btnMove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMove.UseAccentColor = false;
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(455, 20);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(170, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.AutoSize = false;
            this.btnComplete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnComplete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnComplete.Depth = 0;
            this.btnComplete.HighEmphasis = true;
            this.btnComplete.Icon = null;
            this.btnComplete.Location = new System.Drawing.Point(262, 20);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnComplete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnComplete.Size = new System.Drawing.Size(170, 36);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Complete";
            this.btnComplete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnComplete.UseAccentColor = false;
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // cardGV
            // 
            this.cardGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGV.Controls.Add(this.rdoNone);
            this.cardGV.Controls.Add(this.rdoOpen);
            this.cardGV.Controls.Add(this.rdoNoShow);
            this.cardGV.Controls.Add(this.rdoCancelled);
            this.cardGV.Controls.Add(this.rdoCompleted);
            this.cardGV.Controls.Add(this.lblFilter);
            this.cardGV.Controls.Add(this.dgvAppointments);
            this.cardGV.Depth = 0;
            this.cardGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGV.Location = new System.Drawing.Point(21, 52);
            this.cardGV.Margin = new System.Windows.Forms.Padding(14);
            this.cardGV.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGV.Name = "cardGV";
            this.cardGV.Padding = new System.Windows.Forms.Padding(14);
            this.cardGV.Size = new System.Drawing.Size(881, 294);
            this.cardGV.TabIndex = 5;
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Depth = 0;
            this.rdoNone.Location = new System.Drawing.Point(737, 49);
            this.rdoNone.Margin = new System.Windows.Forms.Padding(0);
            this.rdoNone.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoNone.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Ripple = true;
            this.rdoNone.Size = new System.Drawing.Size(72, 37);
            this.rdoNone.TabIndex = 6;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.CheckedChanged += new System.EventHandler(this.rdoNone_CheckedChanged);
            // 
            // rdoOpen
            // 
            this.rdoOpen.AutoSize = true;
            this.rdoOpen.Depth = 0;
            this.rdoOpen.Location = new System.Drawing.Point(737, 86);
            this.rdoOpen.Margin = new System.Windows.Forms.Padding(0);
            this.rdoOpen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoOpen.Name = "rdoOpen";
            this.rdoOpen.Ripple = true;
            this.rdoOpen.Size = new System.Drawing.Size(72, 37);
            this.rdoOpen.TabIndex = 5;
            this.rdoOpen.TabStop = true;
            this.rdoOpen.Text = "Open";
            this.rdoOpen.UseVisualStyleBackColor = true;
            this.rdoOpen.CheckedChanged += new System.EventHandler(this.rdoOpen_CheckedChanged);
            // 
            // rdoNoShow
            // 
            this.rdoNoShow.AutoSize = true;
            this.rdoNoShow.Depth = 0;
            this.rdoNoShow.Location = new System.Drawing.Point(737, 197);
            this.rdoNoShow.Margin = new System.Windows.Forms.Padding(0);
            this.rdoNoShow.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoNoShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoNoShow.Name = "rdoNoShow";
            this.rdoNoShow.Ripple = true;
            this.rdoNoShow.Size = new System.Drawing.Size(99, 37);
            this.rdoNoShow.TabIndex = 4;
            this.rdoNoShow.TabStop = true;
            this.rdoNoShow.Text = "No Show";
            this.rdoNoShow.UseVisualStyleBackColor = true;
            this.rdoNoShow.CheckedChanged += new System.EventHandler(this.rdoNoShow_CheckedChanged);
            // 
            // rdoCancelled
            // 
            this.rdoCancelled.AutoSize = true;
            this.rdoCancelled.Depth = 0;
            this.rdoCancelled.Location = new System.Drawing.Point(737, 160);
            this.rdoCancelled.Margin = new System.Windows.Forms.Padding(0);
            this.rdoCancelled.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoCancelled.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoCancelled.Name = "rdoCancelled";
            this.rdoCancelled.Ripple = true;
            this.rdoCancelled.Size = new System.Drawing.Size(104, 37);
            this.rdoCancelled.TabIndex = 3;
            this.rdoCancelled.TabStop = true;
            this.rdoCancelled.Text = "Cancelled";
            this.rdoCancelled.UseVisualStyleBackColor = true;
            this.rdoCancelled.CheckedChanged += new System.EventHandler(this.rdoCancelled_CheckedChanged);
            // 
            // rdoCompleted
            // 
            this.rdoCompleted.AutoSize = true;
            this.rdoCompleted.Depth = 0;
            this.rdoCompleted.Location = new System.Drawing.Point(737, 123);
            this.rdoCompleted.Margin = new System.Windows.Forms.Padding(0);
            this.rdoCompleted.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoCompleted.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoCompleted.Name = "rdoCompleted";
            this.rdoCompleted.Ripple = true;
            this.rdoCompleted.Size = new System.Drawing.Size(111, 37);
            this.rdoCompleted.TabIndex = 2;
            this.rdoCompleted.TabStop = true;
            this.rdoCompleted.Text = "Completed";
            this.rdoCompleted.UseVisualStyleBackColor = true;
            this.rdoCompleted.CheckedChanged += new System.EventHandler(this.rdoCompleted_CheckedChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Depth = 0;
            this.lblFilter.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFilter.Location = new System.Drawing.Point(734, 17);
            this.lblFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(36, 19);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAppointments.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAppointments.Location = new System.Drawing.Point(20, 17);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(684, 259);
            this.dgvAppointments.TabIndex = 0;
            // 
            // tabCreateAppointment
            // 
            this.tabCreateAppointment.BackColor = System.Drawing.SystemColors.Control;
            this.tabCreateAppointment.Location = new System.Drawing.Point(4, 22);
            this.tabCreateAppointment.Margin = new System.Windows.Forms.Padding(0);
            this.tabCreateAppointment.Name = "tabCreateAppointment";
            this.tabCreateAppointment.Size = new System.Drawing.Size(921, 486);
            this.tabCreateAppointment.TabIndex = 2;
            this.tabCreateAppointment.Text = "Create Appointment";
            // 
            // tabRegiser
            // 
            this.tabRegiser.BackColor = System.Drawing.SystemColors.Control;
            this.tabRegiser.Location = new System.Drawing.Point(4, 22);
            this.tabRegiser.Margin = new System.Windows.Forms.Padding(0);
            this.tabRegiser.Name = "tabRegiser";
            this.tabRegiser.Size = new System.Drawing.Size(921, 486);
            this.tabRegiser.TabIndex = 1;
            this.tabRegiser.Text = "Register Patient";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 582);
            this.Controls.Add(this.materialTab);
            this.DrawerTabControl = this.materialTab;
            this.DrawerWidth = 220;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brighton Medical";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.materialTab.ResumeLayout(false);
            this.tabViewAppointments.ResumeLayout(false);
            this.tabViewAppointments.PerformLayout();
            this.cardActions.ResumeLayout(false);
            this.cardGV.ResumeLayout(false);
            this.cardGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTab;
        private System.Windows.Forms.TabPage tabViewAppointments;
        private System.Windows.Forms.TabPage tabRegiser;
        private System.Windows.Forms.TabPage tabCreateAppointment;
        private MaterialSkin.Controls.MaterialLabel lblActions;
        private MaterialSkin.Controls.MaterialLabel lblAppointments;
        private MaterialSkin.Controls.MaterialCard cardActions;
        private MaterialSkin.Controls.MaterialButton btnRemove;
        private MaterialSkin.Controls.MaterialButton btnMove;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnComplete;
        private MaterialSkin.Controls.MaterialCard cardGV;
        private MaterialSkin.Controls.MaterialRadioButton rdoNone;
        private MaterialSkin.Controls.MaterialRadioButton rdoOpen;
        private MaterialSkin.Controls.MaterialRadioButton rdoNoShow;
        private MaterialSkin.Controls.MaterialRadioButton rdoCancelled;
        private MaterialSkin.Controls.MaterialRadioButton rdoCompleted;
        private MaterialSkin.Controls.MaterialLabel lblFilter;
        private System.Windows.Forms.DataGridView dgvAppointments;
    }
}

