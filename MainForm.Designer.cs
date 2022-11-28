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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCategoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.filterToDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelFilterFrom = new System.Windows.Forms.Label();
            this.labelFilterTo = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.checkBoxFilterDateTime = new System.Windows.Forms.CheckBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.radioButtonExpenses = new System.Windows.Forms.RadioButton();
            this.labelFilterByType = new System.Windows.Forms.Label();
            this.labelFilterByCategory = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.labelActions = new System.Windows.Forms.Label();
            this.buttonAddNewEntry = new System.Windows.Forms.Button();
            this.listViewEntries = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderValue = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCategory = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStripEntry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDescriptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelVisibleSummary = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.contextMenuStripEntry.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(761, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsFileMenuItem,
            this.openMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // saveAsFileMenuItem
            // 
            this.saveAsFileMenuItem.Name = "saveAsFileMenuItem";
            this.saveAsFileMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsFileMenuItem.Text = "Save as";
            this.saveAsFileMenuItem.Click += new System.EventHandler(this.saveAsFileMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // categoriesMenu
            // 
            this.categoriesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCategoriesMenuItem});
            this.categoriesMenu.Name = "categoriesMenu";
            this.categoriesMenu.Size = new System.Drawing.Size(75, 20);
            this.categoriesMenu.Text = "Categories";
            // 
            // manageCategoriesMenuItem
            // 
            this.manageCategoriesMenuItem.Name = "manageCategoriesMenuItem";
            this.manageCategoriesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageCategoriesMenuItem.Text = "Manage";
            this.manageCategoriesMenuItem.Click += new System.EventHandler(this.manageCategoriesMenuItem_Click);
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
            // filterFromDateTime
            // 
            this.filterFromDateTime.Enabled = false;
            this.filterFromDateTime.Location = new System.Drawing.Point(529, 100);
            this.filterFromDateTime.Name = "filterFromDateTime";
            this.filterFromDateTime.Size = new System.Drawing.Size(222, 23);
            this.filterFromDateTime.TabIndex = 0;
            this.filterFromDateTime.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.filterFromDateTime.ValueChanged += new System.EventHandler(this.filterFromDateTime_ValueChanged);
            // 
            // filterToDateTime
            // 
            this.filterToDateTime.Enabled = false;
            this.filterToDateTime.Location = new System.Drawing.Point(529, 144);
            this.filterToDateTime.Name = "filterToDateTime";
            this.filterToDateTime.Size = new System.Drawing.Size(222, 23);
            this.filterToDateTime.TabIndex = 2;
            this.filterToDateTime.Value = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.filterToDateTime.ValueChanged += new System.EventHandler(this.filterToDateTime_ValueChanged);
            // 
            // labelFilterFrom
            // 
            this.labelFilterFrom.AutoSize = true;
            this.labelFilterFrom.Enabled = false;
            this.labelFilterFrom.Location = new System.Drawing.Point(540, 82);
            this.labelFilterFrom.Name = "labelFilterFrom";
            this.labelFilterFrom.Size = new System.Drawing.Size(65, 15);
            this.labelFilterFrom.TabIndex = 3;
            this.labelFilterFrom.Text = "Filter from:";
            // 
            // labelFilterTo
            // 
            this.labelFilterTo.AutoSize = true;
            this.labelFilterTo.Enabled = false;
            this.labelFilterTo.Location = new System.Drawing.Point(540, 126);
            this.labelFilterTo.Name = "labelFilterTo";
            this.labelFilterTo.Size = new System.Drawing.Size(50, 15);
            this.labelFilterTo.TabIndex = 4;
            this.labelFilterTo.Text = "Filter to:";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilter.Location = new System.Drawing.Point(526, 27);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(52, 21);
            this.labelFilter.TabIndex = 5;
            this.labelFilter.Text = "Filters";
            // 
            // checkBoxFilterDateTime
            // 
            this.checkBoxFilterDateTime.AutoSize = true;
            this.checkBoxFilterDateTime.Location = new System.Drawing.Point(529, 60);
            this.checkBoxFilterDateTime.Name = "checkBoxFilterDateTime";
            this.checkBoxFilterDateTime.Size = new System.Drawing.Size(114, 19);
            this.checkBoxFilterDateTime.TabIndex = 6;
            this.checkBoxFilterDateTime.Text = "Filter date range.";
            this.checkBoxFilterDateTime.UseVisualStyleBackColor = true;
            this.checkBoxFilterDateTime.CheckedChanged += new System.EventHandler(this.checkBoxFilterDateTime_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(533, 200);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(39, 19);
            this.radioButtonAll.TabIndex = 7;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(578, 200);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(65, 19);
            this.radioButtonIncome.TabIndex = 8;
            this.radioButtonIncome.Text = "Income";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            this.radioButtonIncome.CheckedChanged += new System.EventHandler(this.radioButtonIncome_CheckedChanged);
            // 
            // radioButtonExpenses
            // 
            this.radioButtonExpenses.AutoSize = true;
            this.radioButtonExpenses.Location = new System.Drawing.Point(649, 200);
            this.radioButtonExpenses.Name = "radioButtonExpenses";
            this.radioButtonExpenses.Size = new System.Drawing.Size(73, 19);
            this.radioButtonExpenses.TabIndex = 9;
            this.radioButtonExpenses.Text = "Expenses";
            this.radioButtonExpenses.UseVisualStyleBackColor = true;
            this.radioButtonExpenses.CheckedChanged += new System.EventHandler(this.radioButtonExpenses_CheckedChanged);
            // 
            // labelFilterByType
            // 
            this.labelFilterByType.AutoSize = true;
            this.labelFilterByType.Location = new System.Drawing.Point(529, 182);
            this.labelFilterByType.Name = "labelFilterByType";
            this.labelFilterByType.Size = new System.Drawing.Size(78, 15);
            this.labelFilterByType.TabIndex = 10;
            this.labelFilterByType.Text = "Filter by type:";
            // 
            // labelFilterByCategory
            // 
            this.labelFilterByCategory.AutoSize = true;
            this.labelFilterByCategory.Location = new System.Drawing.Point(531, 232);
            this.labelFilterByCategory.Name = "labelFilterByCategory";
            this.labelFilterByCategory.Size = new System.Drawing.Size(101, 15);
            this.labelFilterByCategory.TabIndex = 11;
            this.labelFilterByCategory.Text = "Filter by category:";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(531, 250);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(217, 23);
            this.comboBoxCategories.TabIndex = 12;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // labelActions
            // 
            this.labelActions.AutoSize = true;
            this.labelActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActions.Location = new System.Drawing.Point(526, 335);
            this.labelActions.Name = "labelActions";
            this.labelActions.Size = new System.Drawing.Size(61, 21);
            this.labelActions.TabIndex = 13;
            this.labelActions.Text = "Actions";
            // 
            // buttonAddNewEntry
            // 
            this.buttonAddNewEntry.Location = new System.Drawing.Point(532, 359);
            this.buttonAddNewEntry.Name = "buttonAddNewEntry";
            this.buttonAddNewEntry.Size = new System.Drawing.Size(217, 57);
            this.buttonAddNewEntry.TabIndex = 14;
            this.buttonAddNewEntry.Text = "Add new entry";
            this.buttonAddNewEntry.UseVisualStyleBackColor = true;
            this.buttonAddNewEntry.Click += new System.EventHandler(this.buttonAddNewEntry_Click);
            // 
            // listViewEntries
            // 
            this.listViewEntries.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewEntries.AutoArrange = false;
            this.listViewEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderValue,
            this.columnHeaderDate,
            this.columnHeaderCategory});
            this.listViewEntries.ContextMenuStrip = this.contextMenuStripEntry;
            this.listViewEntries.FullRowSelect = true;
            this.listViewEntries.GridLines = true;
            this.listViewEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEntries.Location = new System.Drawing.Point(12, 27);
            this.listViewEntries.MultiSelect = false;
            this.listViewEntries.Name = "listViewEntries";
            this.listViewEntries.Size = new System.Drawing.Size(508, 389);
            this.listViewEntries.TabIndex = 15;
            this.listViewEntries.UseCompatibleStateImageBehavior = false;
            this.listViewEntries.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 100;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            this.columnHeaderValue.Width = 100;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 150;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 150;
            // 
            // contextMenuStripEntry
            // 
            this.contextMenuStripEntry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDescriptionMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripEntry.Name = "contextMenuStripEntry";
            this.contextMenuStripEntry.Size = new System.Drawing.Size(166, 70);
            this.contextMenuStripEntry.Text = "Entry Context Menu";
            this.contextMenuStripEntry.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripEntry_Opening);
            // 
            // showDescriptionMenuItem
            // 
            this.showDescriptionMenuItem.Name = "showDescriptionMenuItem";
            this.showDescriptionMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showDescriptionMenuItem.Text = "Show description";
            this.showDescriptionMenuItem.Click += new System.EventHandler(this.showDescriptionMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(12, 419);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(61, 15);
            this.labelSummary.TabIndex = 16;
            this.labelSummary.Text = "Summary:";
            // 
            // labelVisibleSummary
            // 
            this.labelVisibleSummary.AutoSize = true;
            this.labelVisibleSummary.Location = new System.Drawing.Point(12, 436);
            this.labelVisibleSummary.Name = "labelVisibleSummary";
            this.labelVisibleSummary.Size = new System.Drawing.Size(102, 15);
            this.labelVisibleSummary.TabIndex = 17;
            this.labelVisibleSummary.Text = "Filtered summary:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 457);
            this.Controls.Add(this.labelVisibleSummary);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.listViewEntries);
            this.Controls.Add(this.buttonAddNewEntry);
            this.Controls.Add(this.labelActions);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.labelFilterByCategory);
            this.Controls.Add(this.labelFilterByType);
            this.Controls.Add(this.radioButtonExpenses);
            this.Controls.Add(this.radioButtonIncome);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.checkBoxFilterDateTime);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelFilterTo);
            this.Controls.Add(this.labelFilterFrom);
            this.Controls.Add(this.filterToDateTime);
            this.Controls.Add(this.filterFromDateTime);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Expense manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStripEntry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem saveAsFileMenuItem;
        private ToolStripMenuItem categoriesMenu;
        private ToolStripMenuItem manageCategoriesMenuItem;
        private ToolStripMenuItem moreMenu;
        private ToolStripMenuItem exportMoreMenuItem;
        private ToolStripMenuItem optionsMoreMenuItem;
        private DateTimePicker filterFromDateTime;
        private DateTimePicker filterToDateTime;
        private Label labelFilterFrom;
        private Label labelFilterTo;
        private Label labelFilter;
        private CheckBox checkBoxFilterDateTime;
        private RadioButton radioButtonAll;
        private RadioButton radioButtonIncome;
        private RadioButton radioButtonExpenses;
        private Label labelFilterByType;
        private Label labelFilterByCategory;
        private ComboBox comboBoxCategories;
        private Label labelActions;
        private Button buttonAddNewEntry;
        private ListView listViewEntries;
        private ColumnHeader columnHeaderTitle;
        private ColumnHeader columnHeaderValue;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderCategory;
        private ContextMenuStrip contextMenuStripEntry;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem openMenuItem;
        private Label labelSummary;
        private Label labelVisibleSummary;
        private ToolStripMenuItem showDescriptionMenuItem;
    }
}