using WinForms_Expense_Manager.Classes;
using WinForms_Expense_Manager.Forms;

namespace WinForms_Expense_Manager
{
    public partial class MainForm : Form
    {
        #region Fields
        public readonly ExpenseManager Manager = new();
        private readonly List<Predicate<Entry>> _filters;
        #endregion

        #region Constructor
        public MainForm()
        {
            Manager.LoadData();
            InitializeComponent();

            // ! Register filters
            _filters = new()
            {
                DateRangeFilter,
                TypeFilter,
                CategoryFilter,
            };
        }
        #endregion

        #region Filter Methods
        private List<Entry> ApplyFilters()
        {
            List<Entry> output = new();
            foreach (var entry in Manager.Entries)
            {
                bool pass = true;
                foreach (var filter in _filters)
                {
                    pass = pass && filter(entry);
                }
                if (pass)
                    output.Add(entry);
            }
            return output;
        }

        private bool DateRangeFilter(Entry e)
        {
            if (!checkBoxFilterDateTime.Checked)
                return true;
            if (e.CreatedAt >= filterFromDateTime.Value && e.CreatedAt <= filterToDateTime.Value)
                return true;
            return false;
        }

        private bool TypeFilter(Entry e)
        {
            if (radioButtonAll.Checked)
                return true;
            if (radioButtonExpenses.Checked)
                return e.IsExpense;
            if (radioButtonIncome.Checked)
                return e.IsIncome;
            return false;
        }

        private bool CategoryFilter(Entry e)
        {
            if (comboBoxCategories.SelectedIndex == 0) // Show all categories
                return true;
            string categoryName = comboBoxCategories.SelectedItem.ToString()!;
            Manager.TryGetCategoryId(categoryName, out Guid id);
            if (e.CategoryId == id)
                return true;
            return false;
        }
        #endregion

        #region UI Utilities
        private void PopulateListViewEntries()
        {
            var entries = ApplyFilters();

            listViewEntries.Items.Clear();
            foreach (var entry in entries)
            {
                var item = new ListViewItem(entry.Title);
                item.SubItems.Add(entry.Value.ToString());
                item.SubItems.Add(entry.CreatedAt.ToString());
                Manager.TryGetCategoryName(entry.CategoryId, out string categoryName);
                item.SubItems.Add(categoryName);
                listViewEntries.Items.Add(item);
            }
        }
        #endregion

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initially populate the comboBoxCategories
            comboBoxCategories.Items.Add("Show all");
            comboBoxCategories.SelectedIndex = 0;
            comboBoxCategories.Items.AddRange(Manager.Categories.Values.ToArray());

            // Initially populate the listViewEntries
            PopulateListViewEntries();
        }

        private void checkBoxFilterDateTime_CheckedChanged(object sender, EventArgs e)
        {
            labelFilterFrom.Enabled = checkBoxFilterDateTime.Checked;
            labelFilterTo.Enabled = checkBoxFilterDateTime.Checked;
            filterFromDateTime.Enabled = checkBoxFilterDateTime.Checked;
            filterToDateTime.Enabled = checkBoxFilterDateTime.Checked;

            PopulateListViewEntries();
        }

        private void buttonAddNewEntry_Click(object sender, EventArgs e)
        {
            var addNewEntryForm = new AddNewEntryForm();
            addNewEntryForm.Show();
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void radioButtonIncome_CheckedChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void radioButtonExpenses_CheckedChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void filterFromDateTime_ValueChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void filterToDateTime_ValueChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }
        #endregion

    }
}