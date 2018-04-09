namespace ClientWinformCallingWebAPI
{
    partial class gridForm
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
            this.contactsGridView = new System.Windows.Forms.DataGridView();
            this.insertButon = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contactsGridView
            // 
            this.contactsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.contactsGridView.Location = new System.Drawing.Point(0, 0);
            this.contactsGridView.MultiSelect = false;
            this.contactsGridView.Name = "contactsGridView";
            this.contactsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactsGridView.Size = new System.Drawing.Size(549, 281);
            this.contactsGridView.TabIndex = 0;
            // 
            // insertButon
            // 
            this.insertButon.Location = new System.Drawing.Point(0, 287);
            this.insertButon.Name = "insertButon";
            this.insertButon.Size = new System.Drawing.Size(86, 23);
            this.insertButon.TabIndex = 1;
            this.insertButon.Text = "Insert";
            this.insertButon.UseVisualStyleBackColor = true;
            this.insertButon.Click += new System.EventHandler(this.insertButon_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(109, 287);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(86, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(214, 287);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // gridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 321);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButon);
            this.Controls.Add(this.contactsGridView);
            this.Name = "gridForm";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView contactsGridView;
        private System.Windows.Forms.Button insertButon;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

