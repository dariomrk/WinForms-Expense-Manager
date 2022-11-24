namespace WinForms_Expense_Manager.Forms
{
    partial class EditExistingEntryForm
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
            this.buttonEditExistingEntry = new System.Windows.Forms.Button();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEditExistingEntry
            // 
            this.buttonEditExistingEntry.Location = new System.Drawing.Point(12, 272);
            this.buttonEditExistingEntry.Name = "buttonEditExistingEntry";
            this.buttonEditExistingEntry.Size = new System.Drawing.Size(299, 78);
            this.buttonEditExistingEntry.TabIndex = 24;
            this.buttonEditExistingEntry.Text = "Edit";
            this.buttonEditExistingEntry.UseVisualStyleBackColor = true;
            this.buttonEditExistingEntry.Click += new System.EventHandler(this.buttonEditExistingEntry_Click);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(12, 243);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(299, 23);
            this.comboBoxCategories.TabIndex = 23;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 225);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(98, 15);
            this.labelCategory.TabIndex = 22;
            this.labelCategory.Text = "* Select category:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(12, 166);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(46, 15);
            this.labelValue.TabIndex = 21;
            this.labelValue.Text = "* Value:";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(12, 184);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(299, 23);
            this.textBoxValue.TabIndex = 20;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 62);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(70, 15);
            this.labelDescription.TabIndex = 19;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 80);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(299, 83);
            this.textBoxDescription.TabIndex = 18;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 15);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(12, 26);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(299, 23);
            this.textBoxTitle.TabIndex = 16;
            // 
            // EditExistingEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 362);
            this.Controls.Add(this.buttonEditExistingEntry);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditExistingEntryForm";
            this.Text = "Edit existing entry";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditExistingEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEditExistingEntry;
        private ComboBox comboBoxCategories;
        private Label labelCategory;
        private Label labelValue;
        private TextBox textBoxValue;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelTitle;
        private TextBox textBoxTitle;
    }
}