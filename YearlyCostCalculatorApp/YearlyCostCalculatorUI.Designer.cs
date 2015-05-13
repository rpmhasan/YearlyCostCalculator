namespace YearlyCostCalculatorApp
{
    partial class YearlyCostCalculatorUI
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
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discountCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5",
            "Class 6",
            "Class 7",
            "Class 8",
            "Class 9",
            "Class 10",
            "Class 11",
            "Class 12"});
            this.classComboBox.Location = new System.Drawing.Point(158, 32);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(137, 21);
            this.classComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Class:";
            // 
            // discountCheckBox
            // 
            this.discountCheckBox.AutoSize = true;
            this.discountCheckBox.Location = new System.Drawing.Point(125, 92);
            this.discountCheckBox.Name = "discountCheckBox";
            this.discountCheckBox.Size = new System.Drawing.Size(192, 17);
            this.discountCheckBox.TabIndex = 2;
            this.discountCheckBox.Text = "Get 5% discount for early admission";
            this.discountCheckBox.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(109, 161);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(208, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate total amount for one year";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // YearlyCostCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 261);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.discountCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classComboBox);
            this.Name = "YearlyCostCalculatorUI";
            this.Text = "Yearly Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox discountCheckBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

