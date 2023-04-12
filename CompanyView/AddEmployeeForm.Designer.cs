namespace CompanyView
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LastNameLabel);
            this.panel1.Controls.Add(this.LastNameTextBox);
            this.panel1.Controls.Add(this.addDepartmentButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FirstNameLabel);
            this.panel1.Controls.Add(this.salaryNumericUpDown);
            this.panel1.Controls.Add(this.FirstNameTextBox);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 186);
            this.panel1.TabIndex = 0;
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addDepartmentButton.Location = new System.Drawing.Point(156, 154);
            this.addDepartmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(128, 26);
            this.addDepartmentButton.TabIndex = 7;
            this.addDepartmentButton.Text = "Save employee";
            this.addDepartmentButton.UseVisualStyleBackColor = false;
            this.addDepartmentButton.Click += new System.EventHandler(this.addOrUpdateDepartmentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salary";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 4);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(62, 15);
            this.FirstNameLabel.TabIndex = 3;
            this.FirstNameLabel.Text = "First name";
            this.FirstNameLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.salaryNumericUpDown.Location = new System.Drawing.Point(3, 127);
            this.salaryNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            1500000,
            0,
            0,
            0});
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(281, 23);
            this.salaryNumericUpDown.TabIndex = 2;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FirstNameTextBox.Location = new System.Drawing.Point(3, 22);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(281, 23);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LastNameTextBox.Location = new System.Drawing.Point(3, 74);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(281, 23);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(3, 57);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 15);
            this.LastNameLabel.TabIndex = 9;
            this.LastNameLabel.Text = "Last name";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(326, 206);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddEmployeeForm";
            this.Text = "EmployeeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label FirstNameLabel;
        private NumericUpDown salaryNumericUpDown;
        private TextBox FirstNameTextBox;
        private Button addDepartmentButton;
        private Label LastNameLabel;
        private TextBox LastNameTextBox;
    }
}