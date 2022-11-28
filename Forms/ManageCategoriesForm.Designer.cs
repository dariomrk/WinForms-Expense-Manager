namespace WinForms_Expense_Manager.Forms
{
    partial class ManageCategoriesForm
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
            this.components = new System.ComponentModel.Container();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.contextMenuStripCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddEditCategory = new System.Windows.Forms.Button();
            this.textBoxNewCategory = new System.Windows.Forms.TextBox();
            this.contextMenuStripCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.ContextMenuStrip = this.contextMenuStripCategory;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 15;
            this.listBoxCategories.Location = new System.Drawing.Point(12, 12);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(250, 424);
            this.listBoxCategories.TabIndex = 0;
            // 
            // contextMenuStripCategory
            // 
            this.contextMenuStripCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripCategory.Name = "contextMenuStrip1";
            this.contextMenuStripCategory.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // buttonAddEditCategory
            // 
            this.buttonAddEditCategory.Enabled = false;
            this.buttonAddEditCategory.Location = new System.Drawing.Point(13, 471);
            this.buttonAddEditCategory.Name = "buttonAddEditCategory";
            this.buttonAddEditCategory.Size = new System.Drawing.Size(250, 45);
            this.buttonAddEditCategory.TabIndex = 1;
            this.buttonAddEditCategory.Text = "Add new category";
            this.buttonAddEditCategory.UseVisualStyleBackColor = true;
            this.buttonAddEditCategory.Click += new System.EventHandler(this.buttonAddEditCategory_Click);
            // 
            // textBoxNewCategory
            // 
            this.textBoxNewCategory.Location = new System.Drawing.Point(13, 442);
            this.textBoxNewCategory.Name = "textBoxNewCategory";
            this.textBoxNewCategory.Size = new System.Drawing.Size(250, 23);
            this.textBoxNewCategory.TabIndex = 2;
            this.textBoxNewCategory.TextChanged += new System.EventHandler(this.textBoxNewCategory_TextChanged);
            // 
            // ManageCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 528);
            this.Controls.Add(this.textBoxNewCategory);
            this.Controls.Add(this.buttonAddEditCategory);
            this.Controls.Add(this.listBoxCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageCategoriesForm";
            this.Text = "Manage categories";
            this.Load += new System.EventHandler(this.ManageCategoriesForm_Load);
            this.contextMenuStripCategory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxCategories;
        private Button buttonAddEditCategory;
        private TextBox textBoxNewCategory;
        private ContextMenuStrip contextMenuStripCategory;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}