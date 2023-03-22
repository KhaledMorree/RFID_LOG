
namespace RFID_LOG
{
    partial class Logging
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
            this.btnInitial = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtTagData = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInitial
            // 
            this.btnInitial.BackColor = System.Drawing.Color.Ivory;
            this.btnInitial.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnInitial.Location = new System.Drawing.Point(37, 53);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(221, 71);
            this.btnInitial.TabIndex = 0;
            this.btnInitial.Text = "Set Your Kort";
            this.btnInitial.UseVisualStyleBackColor = false;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRead.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRead.Location = new System.Drawing.Point(37, 141);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(221, 71);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Show Details";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtTagData
            // 
            this.txtTagData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTagData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTagData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTagData.Location = new System.Drawing.Point(328, 65);
            this.txtTagData.Multiline = true;
            this.txtTagData.Name = "txtTagData";
            this.txtTagData.PasswordChar = '*';
            this.txtTagData.ReadOnly = true;
            this.txtTagData.Size = new System.Drawing.Size(209, 59);
            this.txtTagData.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNext.Location = new System.Drawing.Point(678, 380);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 58);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "\r\nVed feil innloging kontakt bruker Støtte 94288174 eller på e-post: Khaledalmorr" +
    "ee18@gmail.com";
            // 
            // Logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtTagData);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnInitial);
            this.ForeColor = System.Drawing.Color.Peru;
            this.Name = "Logging";
            this.Text = "Logging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtTagData;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
    }
}