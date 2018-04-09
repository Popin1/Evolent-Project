namespace ClientWinformCallingWebAPI
{
    partial class InsertOrUpdateForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.firstNameLb = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLb = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLb = new System.Windows.Forms.Label();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(109, 168);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(71, 21);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // firstNameLb
            // 
            this.firstNameLb.AutoSize = true;
            this.firstNameLb.Location = new System.Drawing.Point(18, 23);
            this.firstNameLb.Name = "firstNameLb";
            this.firstNameLb.Size = new System.Drawing.Size(57, 13);
            this.firstNameLb.TabIndex = 1;
            this.firstNameLb.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(109, 20);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(109, 57);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // lastNameLb
            // 
            this.lastNameLb.AutoSize = true;
            this.lastNameLb.Location = new System.Drawing.Point(18, 60);
            this.lastNameLb.Name = "lastNameLb";
            this.lastNameLb.Size = new System.Drawing.Size(58, 13);
            this.lastNameLb.TabIndex = 3;
            this.lastNameLb.Text = "Last Name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(109, 96);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(163, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Location = new System.Drawing.Point(18, 99);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(32, 13);
            this.emailLb.TabIndex = 5;
            this.emailLb.Text = "Email";
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Location = new System.Drawing.Point(109, 133);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(163, 20);
            this.phoneNoTextBox.TabIndex = 8;
            // 
            // phoneNoLb
            // 
            this.phoneNoLb.AutoSize = true;
            this.phoneNoLb.Location = new System.Drawing.Point(18, 136);
            this.phoneNoLb.Name = "phoneNoLb";
            this.phoneNoLb.Size = new System.Drawing.Size(55, 13);
            this.phoneNoLb.TabIndex = 7;
            this.phoneNoLb.Text = "Phone No";
            // 
            // InsertOrUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.phoneNoTextBox);
            this.Controls.Add(this.phoneNoLb);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLb);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLb);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLb);
            this.Controls.Add(this.saveButton);
            this.Name = "InsertOrUpdateForm";
            this.Text = "Insert / Update";
            this.Load += new System.EventHandler(this.InsertOrUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label firstNameLb;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLb;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.Label phoneNoLb;
    }
}