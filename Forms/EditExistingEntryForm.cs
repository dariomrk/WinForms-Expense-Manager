namespace WinForms_Expense_Manager.Forms
{
    public partial class EditExistingEntryForm : Form
    {
        Classes.ExpenseManager _manager;
        Guid _entryId;
        Classes.Entry _editEntry;
        public EditExistingEntryForm(Classes.ExpenseManager manager, Guid entryId)
        {
            _manager=manager;
            _entryId = entryId;
            _manager.TryFindEntry(_entryId, out _editEntry);
            InitializeComponent();
        }

        private void buttonEditExistingEntry_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string description = textBoxDescription.Text;
            string value = textBoxValue.Text;
            decimal parsedValue;

            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Value is a required field!\nPlease fill out the field first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(value, out parsedValue))
            {
                MessageBox.Show("Value must be a number!\nPlease try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (comboBoxCategories.SelectedIndex == 0)
            {
                DialogResult result = MessageBox.Show("You are about to save the entry with no category.\nAre you sure?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            Guid categoryId;
            _manager.TryGetCategoryId(comboBoxCategories.SelectedItem.ToString(), out categoryId);
            Classes.Entry entry = new(_editEntry.Id,_editEntry.CreatedAt,title, description, parsedValue,categoryId);
            _manager.RemoveEntry(_editEntry.Id);
            _manager.AddEntry(entry);
            Close();
        }

        private void EditExistingEntryForm_Load(object sender, EventArgs e)
        {
            // Initially populate the comboBoxCategories
            comboBoxCategories.Items.AddRange(_manager.Categories.Values.ToArray());
            _manager.TryGetCategoryName(_editEntry.CategoryId,out string categoryName);
            for (int i = 0; i < comboBoxCategories.Items.Count; i++)
            {
                if (comboBoxCategories.Items[i].ToString() == categoryName)
                {
                    comboBoxCategories.SelectedIndex = i;
                    break;
                }
            }

            // Populate other fields by info from Entry
            textBoxTitle.Text = _editEntry.Title;
            textBoxDescription.Text = _editEntry.Description;
            textBoxValue.Text = _editEntry.Value.ToString();
        }

    }
}
