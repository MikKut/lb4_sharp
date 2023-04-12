namespace Company
{
    partial class TotalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalForm));
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.departmentTitleTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.updateEmployeeButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ascendingSalaryCheckBox = new System.Windows.Forms.CheckBox();
            this.ascendingFullNameCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fullNameSortButton = new System.Windows.Forms.Button();
            this.salarySortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(330, 21);
            this.employeeDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 29;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.Size = new System.Drawing.Size(253, 235);
            this.employeeDataGridView.TabIndex = 0;
            this.employeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employees";
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.Location = new System.Drawing.Point(10, 21);
            this.departmentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.ReadOnly = true;
            this.departmentDataGridView.RowHeadersWidth = 51;
            this.departmentDataGridView.RowTemplate.Height = 29;
            this.departmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentDataGridView.Size = new System.Drawing.Size(296, 235);
            this.departmentDataGridView.TabIndex = 1;
            this.departmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellContent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.departmentTitleTextBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 146);
            this.panel1.TabIndex = 17;
            // 
            // departmentTitleTextBox
            // 
            this.departmentTitleTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.departmentTitleTextBox.Location = new System.Drawing.Point(4, 17);
            this.departmentTitleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentTitleTextBox.Name = "departmentTitleTextBox";
            this.departmentTitleTextBox.Size = new System.Drawing.Size(163, 23);
            this.departmentTitleTextBox.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(4, 104);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 26);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete Department";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Department\'s Title";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(4, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Department";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(4, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update Department";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.deleteEmployeeButton);
            this.panel3.Controls.Add(this.updateEmployeeButton);
            this.panel3.Controls.Add(this.addEmployeeButton);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(188, 274);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 146);
            this.panel3.TabIndex = 14;
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.BackColor = System.Drawing.Color.Red;
            this.deleteEmployeeButton.Location = new System.Drawing.Point(3, 105);
            this.deleteEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(163, 26);
            this.deleteEmployeeButton.TabIndex = 12;
            this.deleteEmployeeButton.Text = "Delete employee";
            this.deleteEmployeeButton.UseVisualStyleBackColor = false;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateEmployeeButton.Location = new System.Drawing.Point(3, 72);
            this.updateEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(163, 26);
            this.updateEmployeeButton.TabIndex = 11;
            this.updateEmployeeButton.Text = "Update employee";
            this.updateEmployeeButton.UseVisualStyleBackColor = false;
            this.updateEmployeeButton.Click += new System.EventHandler(this.updateEmployeeButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addEmployeeButton.Location = new System.Drawing.Point(3, 42);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(163, 26);
            this.addEmployeeButton.TabIndex = 8;
            this.addEmployeeButton.Text = "Add employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Operations with employee";
            // 
            // saveDataButton
            // 
            this.saveDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveDataButton.Location = new System.Drawing.Point(12, 434);
            this.saveDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(263, 37);
            this.saveDataButton.TabIndex = 18;
            this.saveDataButton.Text = "Save data";
            this.saveDataButton.UseVisualStyleBackColor = false;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.BackColor = System.Drawing.Color.Red;
            this.loadButton.Location = new System.Drawing.Point(281, 433);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(283, 38);
            this.loadButton.TabIndex = 16;
            this.loadButton.Text = "Load data";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.ascendingSalaryCheckBox);
            this.panel4.Controls.Add(this.ascendingFullNameCheckBox);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.fullNameSortButton);
            this.panel4.Controls.Add(this.salarySortButton);
            this.panel4.Location = new System.Drawing.Point(366, 274);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 146);
            this.panel4.TabIndex = 15;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // ascendingSalaryCheckBox
            // 
            this.ascendingSalaryCheckBox.AutoSize = true;
            this.ascendingSalaryCheckBox.Checked = true;
            this.ascendingSalaryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ascendingSalaryCheckBox.Location = new System.Drawing.Point(100, 112);
            this.ascendingSalaryCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ascendingSalaryCheckBox.Name = "ascendingSalaryCheckBox";
            this.ascendingSalaryCheckBox.Size = new System.Drawing.Size(82, 19);
            this.ascendingSalaryCheckBox.TabIndex = 12;
            this.ascendingSalaryCheckBox.Text = "Ascending";
            this.ascendingSalaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // ascendingFullNameCheckBox
            // 
            this.ascendingFullNameCheckBox.AutoSize = true;
            this.ascendingFullNameCheckBox.Checked = true;
            this.ascendingFullNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ascendingFullNameCheckBox.Location = new System.Drawing.Point(3, 112);
            this.ascendingFullNameCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ascendingFullNameCheckBox.Name = "ascendingFullNameCheckBox";
            this.ascendingFullNameCheckBox.Size = new System.Drawing.Size(82, 19);
            this.ascendingFullNameCheckBox.TabIndex = 11;
            this.ascendingFullNameCheckBox.Text = "Ascending";
            this.ascendingFullNameCheckBox.UseVisualStyleBackColor = true;
            this.ascendingFullNameCheckBox.CheckedChanged += new System.EventHandler(this.ascendingFullNameCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sorting operations";
            // 
            // fullNameSortButton
            // 
            this.fullNameSortButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fullNameSortButton.Location = new System.Drawing.Point(3, 22);
            this.fullNameSortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullNameSortButton.Name = "fullNameSortButton";
            this.fullNameSortButton.Size = new System.Drawing.Size(91, 72);
            this.fullNameSortButton.TabIndex = 8;
            this.fullNameSortButton.Text = "Sort by full name";
            this.fullNameSortButton.UseVisualStyleBackColor = false;
            this.fullNameSortButton.Click += new System.EventHandler(this.fullNameSortButton_Click_1);
            // 
            // salarySortButton
            // 
            this.salarySortButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salarySortButton.Location = new System.Drawing.Point(100, 21);
            this.salarySortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salarySortButton.Name = "salarySortButton";
            this.salarySortButton.Size = new System.Drawing.Size(91, 73);
            this.salarySortButton.TabIndex = 9;
            this.salarySortButton.Text = "Sort by Salary";
            this.salarySortButton.UseVisualStyleBackColor = false;
            this.salarySortButton.Click += new System.EventHandler(this.salarySortButton_Click_1);
            // 
            // TotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(606, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentDataGridView);
            this.Controls.Add(this.employeeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(527, 530);
            this.Name = "TotalForm";
            this.Text = "Company form";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView employeeDataGridView;
        private Label label1;
        private Label label2;
        private Button addEmployeeButton2;
        private DataGridView departmentDataGridView;
        private Panel panel1;
        private TextBox departmentTitleTextBox;
        private Button button3;
        private Label label3;
        private Button button1;
        private Button button2;
        private Panel panel3;
        private Button deleteEmployeeButton;
        private Button updateEmployeeButton;
        private Button addEmployeeButton;
        private Label label5;
        private Button saveDataButton;
        private Button loadButton;
        private Panel panel4;
        private CheckBox ascendingSalaryCheckBox;
        private CheckBox ascendingFullNameCheckBox;
        private Label label6;
        private Button fullNameSortButton;
        private Button salarySortButton;
    }
}