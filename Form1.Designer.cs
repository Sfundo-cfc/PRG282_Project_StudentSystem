namespace PRG282_Project_StudentSystem
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMenuOption = new System.Windows.Forms.Button();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.rdbSummary = new System.Windows.Forms.RadioButton();
            this.rdbManage = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.panel4.SuspendLayout();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.lblDate);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnMenuOption);
            this.panel4.Controls.Add(this.grbMenu);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 426);
            this.panel4.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(97, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "CLOSE :)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(490, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "DATE: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "WELCOME!! STUDENT MANAGEMENT SYSTEM ";
            // 
            // btnMenuOption
            // 
            this.btnMenuOption.Location = new System.Drawing.Point(402, 299);
            this.btnMenuOption.Name = "btnMenuOption";
            this.btnMenuOption.Size = new System.Drawing.Size(208, 47);
            this.btnMenuOption.TabIndex = 1;
            this.btnMenuOption.Text = "SELECT OPTION >>>";
            this.btnMenuOption.UseVisualStyleBackColor = true;
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.rdbSummary);
            this.grbMenu.Controls.Add(this.rdbManage);
            this.grbMenu.Controls.Add(this.rdbAdd);
            this.grbMenu.Location = new System.Drawing.Point(62, 38);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(351, 255);
            this.grbMenu.TabIndex = 0;
            this.grbMenu.TabStop = false;
            this.grbMenu.Text = "Menu";
            // 
            // rdbSummary
            // 
            this.rdbSummary.AutoSize = true;
            this.rdbSummary.Location = new System.Drawing.Point(53, 170);
            this.rdbSummary.Name = "rdbSummary";
            this.rdbSummary.Size = new System.Drawing.Size(140, 20);
            this.rdbSummary.TabIndex = 2;
            this.rdbSummary.TabStop = true;
            this.rdbSummary.Text = "Students Summary";
            this.rdbSummary.UseVisualStyleBackColor = true;
            // 
            // rdbManage
            // 
            this.rdbManage.AutoSize = true;
            this.rdbManage.Location = new System.Drawing.Point(53, 115);
            this.rdbManage.Name = "rdbManage";
            this.rdbManage.Size = new System.Drawing.Size(126, 20);
            this.rdbManage.TabIndex = 1;
            this.rdbManage.TabStop = true;
            this.rdbManage.Text = "Manage Student";
            this.rdbManage.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(53, 68);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(108, 20);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add Students";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grbMenu.ResumeLayout(false);
            this.grbMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMenuOption;
        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.RadioButton rdbSummary;
        private System.Windows.Forms.RadioButton rdbManage;
        private System.Windows.Forms.RadioButton rdbAdd;
    }
}

