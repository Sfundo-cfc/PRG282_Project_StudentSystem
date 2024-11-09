namespace PRG282_Project_StudentSystem
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnMenuOption = new System.Windows.Forms.Button();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.rdbSummary = new System.Windows.Forms.RadioButton();
            this.rdbManage = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.grbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.lblDate);
            this.panel4.Controls.Add(this.btnMenuOption);
            this.panel4.Controls.Add(this.grbMenu);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(854, 365);
            this.panel4.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(62, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 44);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "CLOSE :)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(502, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "DATE: ";
            // 
            // btnMenuOption
            // 
            this.btnMenuOption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuOption.Location = new System.Drawing.Point(574, 299);
            this.btnMenuOption.Name = "btnMenuOption";
            this.btnMenuOption.Size = new System.Drawing.Size(208, 44);
            this.btnMenuOption.TabIndex = 1;
            this.btnMenuOption.Text = "SELECT OPTION >>>";
            this.btnMenuOption.UseVisualStyleBackColor = false;
            this.btnMenuOption.Click += new System.EventHandler(this.btnMenuOption_Click);
            // 
            // grbMenu
            // 
            this.grbMenu.BackColor = System.Drawing.Color.Transparent;
            this.grbMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbMenu.BackgroundImage")));
            this.grbMenu.Controls.Add(this.rdbSummary);
            this.grbMenu.Controls.Add(this.rdbManage);
            this.grbMenu.Controls.Add(this.rdbAdd);
            this.grbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbMenu.Location = new System.Drawing.Point(3, 3);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(508, 255);
            this.grbMenu.TabIndex = 0;
            this.grbMenu.TabStop = false;
            this.grbMenu.Text = "Menu";
            // 
            // rdbSummary
            // 
            this.rdbSummary.AutoSize = true;
            this.rdbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSummary.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbSummary.Location = new System.Drawing.Point(53, 170);
            this.rdbSummary.Name = "rdbSummary";
            this.rdbSummary.Size = new System.Drawing.Size(216, 29);
            this.rdbSummary.TabIndex = 2;
            this.rdbSummary.TabStop = true;
            this.rdbSummary.Text = "Students Summary";
            this.rdbSummary.UseVisualStyleBackColor = true;
            // 
            // rdbManage
            // 
            this.rdbManage.AutoSize = true;
            this.rdbManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbManage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbManage.Location = new System.Drawing.Point(53, 115);
            this.rdbManage.Name = "rdbManage";
            this.rdbManage.Size = new System.Drawing.Size(192, 29);
            this.rdbManage.TabIndex = 1;
            this.rdbManage.TabStop = true;
            this.rdbManage.Text = "Manage Student";
            this.rdbManage.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbAdd.Location = new System.Drawing.Point(53, 68);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(164, 29);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add Students";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(854, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 365);
            this.Controls.Add(this.panel4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grbMenu.ResumeLayout(false);
            this.grbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnMenuOption;
        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.RadioButton rdbSummary;
        private System.Windows.Forms.RadioButton rdbManage;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

