namespace WinForms_Expense_Manager
{
    public partial class MainForm : Form
    {
        private Classes.ExpenseManager _manager;
        public MainForm()
        {
            _manager = new();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxFilterDateTime_CheckedChanged(object sender, EventArgs e)
        {
            labelFilterFrom.Enabled = checkBoxFilterDateTime.Checked;
            labelFilterTo.Enabled = checkBoxFilterDateTime.Checked;
            filterFromDateTime.Enabled = checkBoxFilterDateTime.Checked;
            filterToDateTime.Enabled = checkBoxFilterDateTime.Checked;

            // TODO Implement the filter functionality.
        }
    }
}