namespace MassSSH
{
    partial class frmAbout
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
            this.lnklblMail = new System.Windows.Forms.LinkLabel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnklblMail
            // 
            this.lnklblMail.AutoSize = true;
            this.lnklblMail.LinkArea = new System.Windows.Forms.LinkArea(31, 19);
            this.lnklblMail.Location = new System.Drawing.Point(12, 48);
            this.lnklblMail.Name = "lnklblMail";
            this.lnklblMail.Size = new System.Drawing.Size(311, 20);
            this.lnklblMail.TabIndex = 2;
            this.lnklblMail.TabStop = true;
            this.lnklblMail.Tag = "stiiggade@gmail.com";
            this.lnklblMail.Text = "Forslag/ris/ros kan sendes til stiiggade@gmail.com.";
            this.lnklblMail.UseCompatibleTextRendering = true;
            this.lnklblMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblMail_LinkClicked);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(12, 9);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(323, 34);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = "Lavet af Stiig Gade på OIR hold 3 (feb-aug 2016).\r\nVersion {0}";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(286, 74);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Luk";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(373, 109);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lnklblMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(391, 156);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(391, 156);
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Om...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnklblMail;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnClose;
    }
}