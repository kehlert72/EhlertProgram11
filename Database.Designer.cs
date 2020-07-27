namespace EhlertProgram11
{
    partial class frmDatabase
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
            this.lblMembers = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.dgdMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMember)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblMembers.Location = new System.Drawing.Point(207, 43);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(50, 13);
            this.lblMembers.TabIndex = 1;
            this.lblMembers.Text = "Members";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnLoadData.Location = new System.Drawing.Point(155, 283);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnUpdateData.Location = new System.Drawing.Point(236, 283);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateData.TabIndex = 3;
            this.btnUpdateData.Text = "Update Data";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // dgdMember
            // 
            this.dgdMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMember.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dgdMember.Location = new System.Drawing.Point(12, 59);
            this.dgdMember.Name = "dgdMember";
            this.dgdMember.Size = new System.Drawing.Size(456, 218);
            this.dgdMember.TabIndex = 4;
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 386);
            this.Controls.Add(this.dgdMember);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.lblMembers);
            this.Name = "frmDatabase";
            this.Text = "Load and Update Database";
            ((System.ComponentModel.ISupportInitialize)(this.dgdMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.DataGridView dgdMember;
    }
}

