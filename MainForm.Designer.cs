namespace WinForms_Expense_Manager
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCategoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxEntries = new System.Windows.Forms.ListBox();
            this.filterFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.filterToDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelFilterFrom = new System.Windows.Forms.Label();
            this.labelFilterTo = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.checkBoxFilterDateTime = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.categoriesMenu,
            this.moreMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(496, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveFileMenuItem.Text = "Save";
            // 
            // categoriesMenu
            // 
            this.categoriesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoriesMenuItem,
            this.editCategoriesMenuItem,
            this.removeCategoriesMenuItem});
            this.categoriesMenu.Name = "categoriesMenu";
            this.categoriesMenu.Size = new System.Drawing.Size(75, 20);
            this.categoriesMenu.Text = "Categories";
            // 
            // addCategoriesMenuItem
            // 
            this.addCategoriesMenuItem.Name = "addCategoriesMenuItem";
            this.addCategoriesMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addCategoriesMenuItem.Text = "Add";
            // 
            // editCategoriesMenuItem
            // 
            this.editCategoriesMenuItem.Name = "editCategoriesMenuItem";
            this.editCategoriesMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editCategoriesMenuItem.Text = "Edit";
            // 
            // removeCategoriesMenuItem
            // 
            this.removeCategoriesMenuItem.Name = "removeCategoriesMenuItem";
            this.removeCategoriesMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeCategoriesMenuItem.Text = "Remove";
            // 
            // moreMenu
            // 
            this.moreMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportMoreMenuItem,
            this.optionsMoreMenuItem});
            this.moreMenu.Name = "moreMenu";
            this.moreMenu.Size = new System.Drawing.Size(47, 20);
            this.moreMenu.Text = "More";
            // 
            // exportMoreMenuItem
            // 
            this.exportMoreMenuItem.Name = "exportMoreMenuItem";
            this.exportMoreMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exportMoreMenuItem.Text = "Export";
            // 
            // optionsMoreMenuItem
            // 
            this.optionsMoreMenuItem.Name = "optionsMoreMenuItem";
            this.optionsMoreMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsMoreMenuItem.Text = "Options";
            // 
            // listBoxEntries
            // 
            this.listBoxEntries.FormattingEnabled = true;
            this.listBoxEntries.ItemHeight = 15;
            this.listBoxEntries.Location = new System.Drawing.Point(12, 27);
            this.listBoxEntries.Name = "listBoxEntries";
            this.listBoxEntries.Size = new System.Drawing.Size(244, 949);
            this.listBoxEntries.TabIndex = 1;
            // 
            // filterFromDateTime
            // 
            this.filterFromDateTime.Enabled = false;
            this.filterFromDateTime.Location = new System.Drawing.Point(263, 99);
            this.filterFromDateTime.Name = "filterFromDateTime";
            this.filterFromDateTime.Size = new System.Drawing.Size(222, 23);
            this.filterFromDateTime.TabIndex = 0;
            this.filterFromDateTime.Value = new System.DateTime(2022, 10, 22, 19, 21, 46, 790);
            // 
            // filterToDateTime
            // 
            this.filterToDateTime.Enabled = false;
            this.filterToDateTime.Location = new System.Drawing.Point(263, 143);
            this.filterToDateTime.Name = "filterToDateTime";
            this.filterToDateTime.Size = new System.Drawing.Size(222, 23);
            this.filterToDateTime.TabIndex = 2;
            this.filterToDateTime.Value = new System.DateTime(2022, 11, 22, 19, 21, 46, 791);
            // 
            // labelFilterFrom
            // 
            this.labelFilterFrom.AutoSize = true;
            this.labelFilterFrom.Enabled = false;
            this.labelFilterFrom.Location = new System.Drawing.Point(274, 81);
            this.labelFilterFrom.Name = "labelFilterFrom";
            this.labelFilterFrom.Size = new System.Drawing.Size(65, 15);
            this.labelFilterFrom.TabIndex = 3;
            this.labelFilterFrom.Text = "Filter from:";
            // 
            // labelFilterTo
            // 
            this.labelFilterTo.AutoSize = true;
            this.labelFilterTo.Enabled = false;
            this.labelFilterTo.Location = new System.Drawing.Point(274, 125);
            this.labelFilterTo.Name = "labelFilterTo";
            this.labelFilterTo.Size = new System.Drawing.Size(50, 15);
            this.labelFilterTo.TabIndex = 4;
            this.labelFilterTo.Text = "Filter to:";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilter.Location = new System.Drawing.Point(263, 27);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(52, 21);
            this.labelFilter.TabIndex = 5;
            this.labelFilter.Text = "Filters";
            // 
            // checkBoxFilterDateTime
            // 
            this.checkBoxFilterDateTime.AutoSize = true;
            this.checkBoxFilterDateTime.Location = new System.Drawing.Point(263, 59);
            this.checkBoxFilterDateTime.Name = "checkBoxFilterDateTime";
            this.checkBoxFilterDateTime.Size = new System.Drawing.Size(114, 19);
            this.checkBoxFilterDateTime.TabIndex = 6;
            this.checkBoxFilterDateTime.Text = "Filter date range.";
            this.checkBoxFilterDateTime.UseVisualStyleBackColor = true;
            this.checkBoxFilterDateTime.CheckedChanged += new System.EventHandler(this.checkBoxFilterDateTime_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 985);
            this.Controls.Add(this.checkBoxFilterDateTime);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelFilterTo);
            this.Controls.Add(this.labelFilterFrom);
            this.Controls.Add(this.filterToDateTime);
            this.Controls.Add(this.filterFromDateTime);
            this.Controls.Add(this.listBoxEntries);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 1024);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 1024);
            this.Name = "MainForm";
            this.Text = "Expense Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem saveFileMenuItem;
        private ToolStripMenuItem categoriesMenu;
        private ToolStripMenuItem addCategoriesMenuItem;
        private ToolStripMenuItem editCategoriesMenuItem;
        private ToolStripMenuItem removeCategoriesMenuItem;
        private ToolStripMenuItem moreMenu;
        private ToolStripMenuItem exportMoreMenuItem;
        private ToolStripMenuItem optionsMoreMenuItem;
        private ListBox listBoxEntries;
        private DateTimePicker filterFromDateTime;
        private DateTimePicker filterToDateTime;
        private Label labelFilterFrom;
        private Label labelFilterTo;
        private Label labelFilter;
        private CheckBox checkBoxFilterDateTime;
    }
}