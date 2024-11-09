namespace StudentManagementSystem
{
    partial class frmManage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.numFillAge = new System.Windows.Forms.NumericUpDown();
            this.cmbFillCourse = new System.Windows.Forms.ComboBox();
            this.txtFillLastName = new System.Windows.Forms.TextBox();
            this.txtFillName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFillAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numFillAge);
            this.panel2.Controls.Add(this.cmbFillCourse);
            this.panel2.Controls.Add(this.txtFillLastName);
            this.panel2.Controls.Add(this.txtFillName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.dgvStudents);
            this.panel2.Location = new System.Drawing.Point(146, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 451);
            this.panel2.TabIndex = 6;
            // 
            // numFillAge
            // 
            this.numFillAge.Location = new System.Drawing.Point(505, 255);
            this.numFillAge.Name = "numFillAge";
            this.numFillAge.Size = new System.Drawing.Size(203, 22);
            this.numFillAge.TabIndex = 14;
            this.numFillAge.Visible = false;
            // 
            // cmbFillCourse
            // 
            this.cmbFillCourse.FormattingEnabled = true;
            this.cmbFillCourse.Items.AddRange(new object[] {
            "BComp",
            "BIT",
            "DIT",
            "National Certificate"});
            this.cmbFillCourse.Location = new System.Drawing.Point(505, 298);
            this.cmbFillCourse.Name = "cmbFillCourse";
            this.cmbFillCourse.Size = new System.Drawing.Size(203, 24);
            this.cmbFillCourse.TabIndex = 13;
            this.cmbFillCourse.Visible = false;
            // 
            // txtFillLastName
            // 
            this.txtFillLastName.Location = new System.Drawing.Point(505, 193);
            this.txtFillLastName.Name = "txtFillLastName";
            this.txtFillLastName.Size = new System.Drawing.Size(203, 22);
            this.txtFillLastName.TabIndex = 11;
            this.txtFillLastName.Visible = false;
            // 
            // txtFillName
            // 
            this.txtFillName.Location = new System.Drawing.Point(505, 146);
            this.txtFillName.Name = "txtFillName";
            this.txtFillName.Size = new System.Drawing.Size(203, 22);
            this.txtFillName.TabIndex = 10;
            this.txtFillName.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student Details Management";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(495, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back!";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(204, 402);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(368, 402);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(29, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Age,
            this.Course});
            this.dgvStudents.Location = new System.Drawing.Point(44, 125);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(399, 197);
            this.dgvStudents.TabIndex = 5;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.Width = 125;
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 627);
            this.Controls.Add(this.panel2);
            this.Name = "frmManage";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmManage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFillAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numFillAge;
        private System.Windows.Forms.ComboBox cmbFillCourse;
        private System.Windows.Forms.TextBox txtFillLastName;
        private System.Windows.Forms.TextBox txtFillName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
    }
}