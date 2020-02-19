namespace fullTimePartTime
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnWhatStatus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of credits";
            // 
            // btnWhatStatus
            // 
            this.btnWhatStatus.Location = new System.Drawing.Point(88, 78);
            this.btnWhatStatus.Name = "btnWhatStatus";
            this.btnWhatStatus.Size = new System.Drawing.Size(124, 23);
            this.btnWhatStatus.TabIndex = 2;
            this.btnWhatStatus.Text = "What\'s my status?";
            this.btnWhatStatus.UseVisualStyleBackColor = true;
            this.btnWhatStatus.Click += new System.EventHandler(this.btnWhatStatus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(62, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(178, 23);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status shown here";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(173, 38);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(100, 20);
            this.txtCredits.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 153);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnWhatStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCredits);
            this.Name = "Form1";
            this.Text = "Full time, half time?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWhatStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCredits;
    }
}

