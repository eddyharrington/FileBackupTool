namespace FileBackupTool
{
    partial class FormNewBackup
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
            this.lblBackupFrom = new System.Windows.Forms.Label();
            this.txtBoxBackupFrom = new System.Windows.Forms.TextBox();
            this.btnBackupFrom = new System.Windows.Forms.Button();
            this.btnStartBackup = new System.Windows.Forms.Button();
            this.lblBackupFromValidate = new System.Windows.Forms.Label();
            this.lblBackupToValidate = new System.Windows.Forms.Label();
            this.txtBoxBackupName = new System.Windows.Forms.TextBox();
            this.lblBackupName = new System.Windows.Forms.Label();
            this.btnBackupTo = new System.Windows.Forms.Button();
            this.txtBoxBackupTo = new System.Windows.Forms.TextBox();
            this.lblBackupTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBackupFrom
            // 
            this.lblBackupFrom.AutoSize = true;
            this.lblBackupFrom.Location = new System.Drawing.Point(9, 62);
            this.lblBackupFrom.Name = "lblBackupFrom";
            this.lblBackupFrom.Size = new System.Drawing.Size(70, 13);
            this.lblBackupFrom.TabIndex = 0;
            this.lblBackupFrom.Text = "Backup from:";
            // 
            // txtBoxBackupFrom
            // 
            this.txtBoxBackupFrom.Location = new System.Drawing.Point(85, 59);
            this.txtBoxBackupFrom.Name = "txtBoxBackupFrom";
            this.txtBoxBackupFrom.Size = new System.Drawing.Size(219, 20);
            this.txtBoxBackupFrom.TabIndex = 2;
            // 
            // btnBackupFrom
            // 
            this.btnBackupFrom.Location = new System.Drawing.Point(310, 57);
            this.btnBackupFrom.Name = "btnBackupFrom";
            this.btnBackupFrom.Size = new System.Drawing.Size(75, 23);
            this.btnBackupFrom.TabIndex = 4;
            this.btnBackupFrom.Text = "Browse...";
            this.btnBackupFrom.UseVisualStyleBackColor = true;
            this.btnBackupFrom.Click += new System.EventHandler(this.btnBackupFrom_Click);
            // 
            // btnStartBackup
            // 
            this.btnStartBackup.BackColor = System.Drawing.Color.Green;
            this.btnStartBackup.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnStartBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBackup.ForeColor = System.Drawing.Color.White;
            this.btnStartBackup.Location = new System.Drawing.Point(391, 57);
            this.btnStartBackup.Name = "btnStartBackup";
            this.btnStartBackup.Size = new System.Drawing.Size(75, 23);
            this.btnStartBackup.TabIndex = 7;
            this.btnStartBackup.Text = "Backup!";
            this.btnStartBackup.UseVisualStyleBackColor = false;
            this.btnStartBackup.Click += new System.EventHandler(this.btnStartBackup_Click);
            // 
            // lblBackupFromValidate
            // 
            this.lblBackupFromValidate.AutoSize = true;
            this.lblBackupFromValidate.Location = new System.Drawing.Point(239, 36);
            this.lblBackupFromValidate.Name = "lblBackupFromValidate";
            this.lblBackupFromValidate.Size = new System.Drawing.Size(0, 13);
            this.lblBackupFromValidate.TabIndex = 14;
            // 
            // lblBackupToValidate
            // 
            this.lblBackupToValidate.AutoSize = true;
            this.lblBackupToValidate.Location = new System.Drawing.Point(239, 62);
            this.lblBackupToValidate.Name = "lblBackupToValidate";
            this.lblBackupToValidate.Size = new System.Drawing.Size(0, 13);
            this.lblBackupToValidate.TabIndex = 15;
            // 
            // txtBoxBackupName
            // 
            this.txtBoxBackupName.Location = new System.Drawing.Point(85, 7);
            this.txtBoxBackupName.Name = "txtBoxBackupName";
            this.txtBoxBackupName.Size = new System.Drawing.Size(185, 20);
            this.txtBoxBackupName.TabIndex = 19;
            // 
            // lblBackupName
            // 
            this.lblBackupName.AutoSize = true;
            this.lblBackupName.Location = new System.Drawing.Point(3, 10);
            this.lblBackupName.Name = "lblBackupName";
            this.lblBackupName.Size = new System.Drawing.Size(76, 13);
            this.lblBackupName.TabIndex = 21;
            this.lblBackupName.Text = "Backup name:";
            // 
            // btnBackupTo
            // 
            this.btnBackupTo.Location = new System.Drawing.Point(310, 31);
            this.btnBackupTo.Name = "btnBackupTo";
            this.btnBackupTo.Size = new System.Drawing.Size(75, 23);
            this.btnBackupTo.TabIndex = 28;
            this.btnBackupTo.Text = "Browse...";
            this.btnBackupTo.UseVisualStyleBackColor = true;
            this.btnBackupTo.Click += new System.EventHandler(this.btnBackupTo_Click);
            // 
            // txtBoxBackupTo
            // 
            this.txtBoxBackupTo.Location = new System.Drawing.Point(85, 33);
            this.txtBoxBackupTo.Name = "txtBoxBackupTo";
            this.txtBoxBackupTo.Size = new System.Drawing.Size(219, 20);
            this.txtBoxBackupTo.TabIndex = 27;
            // 
            // lblBackupTo
            // 
            this.lblBackupTo.AutoSize = true;
            this.lblBackupTo.Location = new System.Drawing.Point(20, 36);
            this.lblBackupTo.Name = "lblBackupTo";
            this.lblBackupTo.Size = new System.Drawing.Size(59, 13);
            this.lblBackupTo.TabIndex = 26;
            this.lblBackupTo.Text = "Backup to:";
            // 
            // FormNewBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 93);
            this.Controls.Add(this.btnBackupTo);
            this.Controls.Add(this.txtBoxBackupTo);
            this.Controls.Add(this.lblBackupTo);
            this.Controls.Add(this.lblBackupName);
            this.Controls.Add(this.txtBoxBackupName);
            this.Controls.Add(this.lblBackupToValidate);
            this.Controls.Add(this.lblBackupFromValidate);
            this.Controls.Add(this.btnStartBackup);
            this.Controls.Add(this.btnBackupFrom);
            this.Controls.Add(this.txtBoxBackupFrom);
            this.Controls.Add(this.lblBackupFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNewBackup";
            this.Text = "New Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackupFrom;
        private System.Windows.Forms.TextBox txtBoxBackupFrom;
        private System.Windows.Forms.Button btnBackupFrom;
        private System.Windows.Forms.Button btnStartBackup;
        private System.Windows.Forms.Label lblBackupFromValidate;
        private System.Windows.Forms.Label lblBackupToValidate;
        private System.Windows.Forms.TextBox txtBoxBackupName;
        private System.Windows.Forms.Label lblBackupName;
        private System.Windows.Forms.Button btnBackupTo;
        private System.Windows.Forms.TextBox txtBoxBackupTo;
        private System.Windows.Forms.Label lblBackupTo;
    }
}

