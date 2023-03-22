
namespace RFID_LOG
{
    partial class RegiserId
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
            this.btnScann = new System.Windows.Forms.Button();
            this.btnInitiall = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.dgvId = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnVeiw = new System.Windows.Forms.Button();
            this.btnDeletTag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnsattName = new System.Windows.Forms.TextBox();
            this.cboAnsatNAvnn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScann
            // 
            this.btnScann.BackColor = System.Drawing.Color.DarkOrange;
            this.btnScann.Location = new System.Drawing.Point(12, 125);
            this.btnScann.Name = "btnScann";
            this.btnScann.Size = new System.Drawing.Size(120, 120);
            this.btnScann.TabIndex = 0;
            this.btnScann.Text = "Read";
            this.btnScann.UseVisualStyleBackColor = false;
            this.btnScann.Click += new System.EventHandler(this.btnScann_Click);
            // 
            // btnInitiall
            // 
            this.btnInitiall.BackColor = System.Drawing.Color.GreenYellow;
            this.btnInitiall.Location = new System.Drawing.Point(12, 12);
            this.btnInitiall.Name = "btnInitiall";
            this.btnInitiall.Size = new System.Drawing.Size(120, 107);
            this.btnInitiall.TabIndex = 1;
            this.btnInitiall.Text = "Set Tag";
            this.btnInitiall.UseVisualStyleBackColor = false;
            this.btnInitiall.Click += new System.EventHandler(this.btnInitiall_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(242, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 43);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update ID";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboId
            // 
            this.cboId.FormattingEnabled = true;
            this.cboId.Location = new System.Drawing.Point(163, 320);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(121, 24);
            this.cboId.TabIndex = 3;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(303, 320);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 22);
            this.txtBoxId.TabIndex = 4;
            // 
            // dgvId
            // 
            this.dgvId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvId.Location = new System.Drawing.Point(138, 12);
            this.dgvId.Name = "dgvId";
            this.dgvId.RowHeadersWidth = 51;
            this.dgvId.RowTemplate.Height = 24;
            this.dgvId.Size = new System.Drawing.Size(641, 270);
            this.dgvId.TabIndex = 5;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Fuchsia;
            this.btnInsert.ForeColor = System.Drawing.Color.Aqua;
            this.btnInsert.Location = new System.Drawing.Point(683, 307);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 48);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnVeiw
            // 
            this.btnVeiw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVeiw.Location = new System.Drawing.Point(12, 272);
            this.btnVeiw.Name = "btnVeiw";
            this.btnVeiw.Size = new System.Drawing.Size(120, 74);
            this.btnVeiw.TabIndex = 7;
            this.btnVeiw.Text = "View all Tags";
            this.btnVeiw.UseVisualStyleBackColor = false;
            this.btnVeiw.Click += new System.EventHandler(this.btnVeiw_Click);
            // 
            // btnDeletTag
            // 
            this.btnDeletTag.BackColor = System.Drawing.Color.Cyan;
            this.btnDeletTag.Location = new System.Drawing.Point(12, 352);
            this.btnDeletTag.Name = "btnDeletTag";
            this.btnDeletTag.Size = new System.Drawing.Size(120, 43);
            this.btnDeletTag.TabIndex = 8;
            this.btnDeletTag.Text = "Delete Tag";
            this.btnDeletTag.UseVisualStyleBackColor = false;
            this.btnDeletTag.Click += new System.EventHandler(this.btnDeletTag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(163, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(300, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Employee ID";
            // 
            // txtAnsattName
            // 
            this.txtAnsattName.Location = new System.Drawing.Point(547, 320);
            this.txtAnsattName.Name = "txtAnsattName";
            this.txtAnsattName.Size = new System.Drawing.Size(100, 22);
            this.txtAnsattName.TabIndex = 11;
            // 
            // cboAnsatNAvnn
            // 
            this.cboAnsatNAvnn.FormattingEnabled = true;
            this.cboAnsatNAvnn.Location = new System.Drawing.Point(430, 320);
            this.cboAnsatNAvnn.Name = "cboAnsatNAvnn";
            this.cboAnsatNAvnn.Size = new System.Drawing.Size(100, 24);
            this.cboAnsatNAvnn.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(427, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Employee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(544, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "New Name";
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.BackColor = System.Drawing.Color.Green;
            this.btnUpdateName.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpdateName.Location = new System.Drawing.Point(492, 352);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(96, 43);
            this.btnUpdateName.TabIndex = 15;
            this.btnUpdateName.Text = "Update Name";
            this.btnUpdateName.UseVisualStyleBackColor = false;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // RegiserId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboAnsatNAvnn);
            this.Controls.Add(this.txtAnsattName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletTag);
            this.Controls.Add(this.btnVeiw);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvId);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.cboId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInitiall);
            this.Controls.Add(this.btnScann);
            this.Name = "RegiserId";
            this.Text = "RegiserId";
            ((System.ComponentModel.ISupportInitialize)(this.dgvId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScann;
        private System.Windows.Forms.Button btnInitiall;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.DataGridView dgvId;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnVeiw;
        private System.Windows.Forms.Button btnDeletTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnsattName;
        private System.Windows.Forms.ComboBox cboAnsatNAvnn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateName;
    }
}