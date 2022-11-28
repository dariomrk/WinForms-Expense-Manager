namespace WinForms_Expense_Manager.Forms
{
    public partial class ShowDescriptionForm : Form
    {
        string _description;
        public ShowDescriptionForm(Classes.ExpenseManager manager, Guid id)
        {
            manager.TryFindEntry(id,out Classes.Entry entry);
            _description = entry.Description;
            InitializeComponent();
        }

        private void ShowDescriptionForm_Load(object sender, EventArgs e)
        {
            richTextBoxDescription.Text = String.IsNullOrEmpty(_description) ?
                "No description available." : _description;
        }
    }
}
