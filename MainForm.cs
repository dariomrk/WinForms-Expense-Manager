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
            // Initially populate the listViewEntries with the loaded data
            foreach(var entry in _manager.Entries)
            {
                var item = new ListViewItem(entry.Title);
                item.SubItems.Add(entry.Value.ToString());
                item.SubItems.Add(entry.CreatedAt.ToString());
                _manager.TryGetCategoryName(entry.CategoryId, out string categoryName);
                item.SubItems.Add(categoryName);
                listViewEntries.Items.Add(item);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}