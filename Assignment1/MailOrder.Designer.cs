namespace Assignment1
{
    partial class MailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.Logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.Languages_groupBox = new System.Windows.Forms.GroupBox();
            this.Spanish_radioButton = new System.Windows.Forms.RadioButton();
            this.Francais_radioButton = new System.Windows.Forms.RadioButton();
            this.English_radioButton = new System.Windows.Forms.RadioButton();
            this.EmpName_label = new System.Windows.Forms.Label();
            this.EmpID_label = new System.Windows.Forms.Label();
            this.HoursWorked_label = new System.Windows.Forms.Label();
            this.TotalSales_label = new System.Windows.Forms.Label();
            this.SalesBonus_label = new System.Windows.Forms.Label();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.Print_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.EmpName_textBox = new System.Windows.Forms.TextBox();
            this.EmpID_textBox = new System.Windows.Forms.TextBox();
            this.HoursWorked_textBox = new System.Windows.Forms.TextBox();
            this.TotalSales_textBox = new System.Windows.Forms.TextBox();
            this.SalesBonus_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pictureBox)).BeginInit();
            this.Languages_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo_pictureBox
            // 
            this.Logo_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo_pictureBox.Image = global::Assignment1.Properties.Resources.Logo;
            this.Logo_pictureBox.ImageLocation = "";
            this.Logo_pictureBox.Location = new System.Drawing.Point(28, 33);
            this.Logo_pictureBox.Name = "Logo_pictureBox";
            this.Logo_pictureBox.Size = new System.Drawing.Size(168, 109);
            this.Logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_pictureBox.TabIndex = 0;
            this.Logo_pictureBox.TabStop = false;
            // 
            // Languages_groupBox
            // 
            this.Languages_groupBox.Controls.Add(this.Spanish_radioButton);
            this.Languages_groupBox.Controls.Add(this.Francais_radioButton);
            this.Languages_groupBox.Controls.Add(this.English_radioButton);
            this.Languages_groupBox.Location = new System.Drawing.Point(214, 33);
            this.Languages_groupBox.Name = "Languages_groupBox";
            this.Languages_groupBox.Size = new System.Drawing.Size(200, 109);
            this.Languages_groupBox.TabIndex = 1;
            this.Languages_groupBox.TabStop = false;
            this.Languages_groupBox.Text = "Languages";
            // 
            // Spanish_radioButton
            // 
            this.Spanish_radioButton.AutoSize = true;
            this.Spanish_radioButton.Location = new System.Drawing.Point(2, 85);
            this.Spanish_radioButton.Name = "Spanish_radioButton";
            this.Spanish_radioButton.Size = new System.Drawing.Size(92, 24);
            this.Spanish_radioButton.TabIndex = 8;
            this.Spanish_radioButton.Text = "Spanish";
            this.Spanish_radioButton.UseVisualStyleBackColor = true;
            this.Spanish_radioButton.CheckedChanged += new System.EventHandler(this.Spanish_radioButton_CheckedChanged);
            // 
            // Francais_radioButton
            // 
            this.Francais_radioButton.AutoSize = true;
            this.Francais_radioButton.Location = new System.Drawing.Point(1, 54);
            this.Francais_radioButton.Name = "Francais_radioButton";
            this.Francais_radioButton.Size = new System.Drawing.Size(95, 24);
            this.Francais_radioButton.TabIndex = 8;
            this.Francais_radioButton.Text = "Francais";
            this.Francais_radioButton.UseVisualStyleBackColor = true;
            this.Francais_radioButton.CheckedChanged += new System.EventHandler(this.Francais_radioButton_CheckedChanged);
            // 
            // English_radioButton
            // 
            this.English_radioButton.AutoSize = true;
            this.English_radioButton.Checked = true;
            this.English_radioButton.Location = new System.Drawing.Point(1, 24);
            this.English_radioButton.Name = "English_radioButton";
            this.English_radioButton.Size = new System.Drawing.Size(86, 24);
            this.English_radioButton.TabIndex = 8;
            this.English_radioButton.TabStop = true;
            this.English_radioButton.Text = "English";
            this.English_radioButton.UseVisualStyleBackColor = true;
            this.English_radioButton.CheckedChanged += new System.EventHandler(this.English_radioButton_CheckedChanged);
            // 
            // EmpName_label
            // 
            this.EmpName_label.AutoSize = true;
            this.EmpName_label.Location = new System.Drawing.Point(38, 184);
            this.EmpName_label.Name = "EmpName_label";
            this.EmpName_label.Size = new System.Drawing.Size(140, 20);
            this.EmpName_label.TabIndex = 2;
            this.EmpName_label.Text = "Employee\'s Name:";
            // 
            // EmpID_label
            // 
            this.EmpID_label.AutoSize = true;
            this.EmpID_label.Location = new System.Drawing.Point(38, 226);
            this.EmpID_label.Name = "EmpID_label";
            this.EmpID_label.Size = new System.Drawing.Size(104, 20);
            this.EmpID_label.TabIndex = 3;
            this.EmpID_label.Text = "Employee ID:";
            // 
            // HoursWorked_label
            // 
            this.HoursWorked_label.AutoSize = true;
            this.HoursWorked_label.Location = new System.Drawing.Point(38, 266);
            this.HoursWorked_label.Name = "HoursWorked_label";
            this.HoursWorked_label.Size = new System.Drawing.Size(115, 20);
            this.HoursWorked_label.TabIndex = 4;
            this.HoursWorked_label.Text = "Hours Worked:";
            // 
            // TotalSales_label
            // 
            this.TotalSales_label.AutoSize = true;
            this.TotalSales_label.Location = new System.Drawing.Point(38, 308);
            this.TotalSales_label.Name = "TotalSales_label";
            this.TotalSales_label.Size = new System.Drawing.Size(92, 20);
            this.TotalSales_label.TabIndex = 5;
            this.TotalSales_label.Text = "Total Sales:";
            // 
            // SalesBonus_label
            // 
            this.SalesBonus_label.AutoSize = true;
            this.SalesBonus_label.Location = new System.Drawing.Point(38, 349);
            this.SalesBonus_label.Name = "SalesBonus_label";
            this.SalesBonus_label.Size = new System.Drawing.Size(103, 20);
            this.SalesBonus_label.TabIndex = 6;
            this.SalesBonus_label.Text = "Sales Bonus:";
            // 
            // Calculate_button
            // 
            this.Calculate_button.Location = new System.Drawing.Point(28, 408);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(102, 33);
            this.Calculate_button.TabIndex = 5;
            this.Calculate_button.Text = "Calculate";
            this.Calculate_button.UseVisualStyleBackColor = true;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // Print_button
            // 
            this.Print_button.Location = new System.Drawing.Point(168, 408);
            this.Print_button.Name = "Print_button";
            this.Print_button.Size = new System.Drawing.Size(102, 33);
            this.Print_button.TabIndex = 6;
            this.Print_button.Text = "Print";
            this.Print_button.UseVisualStyleBackColor = true;
            this.Print_button.Click += new System.EventHandler(this.Print_button_Click);
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(312, 408);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(102, 33);
            this.Next_button.TabIndex = 7;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // EmpName_textBox
            // 
            this.EmpName_textBox.Location = new System.Drawing.Point(203, 181);
            this.EmpName_textBox.Name = "EmpName_textBox";
            this.EmpName_textBox.Size = new System.Drawing.Size(211, 26);
            this.EmpName_textBox.TabIndex = 1;
            this.EmpName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpName_textBox_KeyPress);
            // 
            // EmpID_textBox
            // 
            this.EmpID_textBox.Location = new System.Drawing.Point(203, 220);
            this.EmpID_textBox.Name = "EmpID_textBox";
            this.EmpID_textBox.Size = new System.Drawing.Size(150, 26);
            this.EmpID_textBox.TabIndex = 2;
            this.EmpID_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustDigits_textBox_KeyPress);
            // 
            // HoursWorked_textBox
            // 
            this.HoursWorked_textBox.Location = new System.Drawing.Point(203, 260);
            this.HoursWorked_textBox.MaxLength = 3;
            this.HoursWorked_textBox.Name = "HoursWorked_textBox";
            this.HoursWorked_textBox.Size = new System.Drawing.Size(150, 26);
            this.HoursWorked_textBox.TabIndex = 3;
            this.HoursWorked_textBox.TextChanged += new System.EventHandler(this.HoursWorked_textBox_TextChanged);
            this.HoursWorked_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustDigits_textBox_KeyPress);
            // 
            // TotalSales_textBox
            // 
            this.TotalSales_textBox.Location = new System.Drawing.Point(203, 302);
            this.TotalSales_textBox.Name = "TotalSales_textBox";
            this.TotalSales_textBox.Size = new System.Drawing.Size(150, 26);
            this.TotalSales_textBox.TabIndex = 4;
            this.TotalSales_textBox.Text = "$0.00";
            this.TotalSales_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustDigits_textBox_KeyPress);
            this.TotalSales_textBox.Leave += new System.EventHandler(this.TotalSales_textBox_Leave);
            // 
            // SalesBonus_textBox
            // 
            this.SalesBonus_textBox.Location = new System.Drawing.Point(203, 343);
            this.SalesBonus_textBox.Name = "SalesBonus_textBox";
            this.SalesBonus_textBox.ReadOnly = true;
            this.SalesBonus_textBox.Size = new System.Drawing.Size(150, 26);
            this.SalesBonus_textBox.TabIndex = 14;
            this.SalesBonus_textBox.TabStop = false;
            this.SalesBonus_textBox.Text = "$0.00";
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 462);
            this.Controls.Add(this.SalesBonus_textBox);
            this.Controls.Add(this.TotalSales_textBox);
            this.Controls.Add(this.HoursWorked_textBox);
            this.Controls.Add(this.EmpID_textBox);
            this.Controls.Add(this.EmpName_textBox);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Print_button);
            this.Controls.Add(this.Calculate_button);
            this.Controls.Add(this.SalesBonus_label);
            this.Controls.Add(this.TotalSales_label);
            this.Controls.Add(this.HoursWorked_label);
            this.Controls.Add(this.EmpID_label);
            this.Controls.Add(this.EmpName_label);
            this.Controls.Add(this.Languages_groupBox);
            this.Controls.Add(this.Logo_pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(461, 518);
            this.MinimumSize = new System.Drawing.Size(461, 518);
            this.Name = "MailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pictureBox)).EndInit();
            this.Languages_groupBox.ResumeLayout(false);
            this.Languages_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_pictureBox;
        private System.Windows.Forms.GroupBox Languages_groupBox;
        private System.Windows.Forms.RadioButton Spanish_radioButton;
        private System.Windows.Forms.RadioButton Francais_radioButton;
        private System.Windows.Forms.RadioButton English_radioButton;
        private System.Windows.Forms.Label EmpName_label;
        private System.Windows.Forms.Label EmpID_label;
        private System.Windows.Forms.Label HoursWorked_label;
        private System.Windows.Forms.Label TotalSales_label;
        private System.Windows.Forms.Label SalesBonus_label;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.Button Print_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.TextBox EmpName_textBox;
        private System.Windows.Forms.TextBox EmpID_textBox;
        private System.Windows.Forms.TextBox HoursWorked_textBox;
        private System.Windows.Forms.TextBox TotalSales_textBox;
        private System.Windows.Forms.TextBox SalesBonus_textBox;
    }
}

