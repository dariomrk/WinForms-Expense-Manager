namespace WinForms_Expense_Manager
{
    public partial class MainForm : Form
    {
        private readonly Classes.ExpenseManager _manager = new();

        public MainForm()
        {
            _manager.LoadData();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach(var entry in _manager.Entries)
            {
                listBoxEntries.Items.Add($"{entry.Title} {entry.Value}");
            }

            foreach(var category in _manager.Categories)
            {
                comboBoxCategories.Items.Add($"{category.Value}");
            }
        }

        private void checkBoxFilterDateTime_CheckedChanged(object sender, EventArgs e)
        {
            labelFilterFrom.Enabled = checkBoxFilterDateTime.Checked;
            labelFilterTo.Enabled = checkBoxFilterDateTime.Checked;
            filterFromDateTime.Enabled = checkBoxFilterDateTime.Checked;
            filterToDateTime.Enabled = checkBoxFilterDateTime.Checked;

            // TODO Implement the filter functionality.
        }

        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            _manager.SaveData();
        }
    }
}