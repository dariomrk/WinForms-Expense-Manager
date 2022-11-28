using System;
namespace WinForms_Expense_Manager.Forms
{
    public partial class ManageCategoriesForm : Form
    {
        private Classes.ExpenseManager _manager;
        private bool _isEditingCategory = false;
        private string _categoryEditing="";
        public ManageCategoriesForm(Classes.ExpenseManager manager)
        {
            InitializeComponent();
            _manager=manager;
        }
        private void ResetAllControls()
        {
            _categoryEditing="";
            _isEditingCategory = false;
            buttonAddEditCategory.Enabled = false;
            listBoxCategories.Enabled = true;
            textBoxNewCategory.Clear();
            buttonAddEditCategory.Text = "Add new category";
        }
        private void SetButtonEdit()
        {
            buttonAddEditCategory.Text = "Edit category name";
            _isEditingCategory = true;
        }
        private void PopulateListBoxCategories()
        {
            listBoxCategories.Items.Clear();
            foreach (var item in _manager.Categories)
            {
                if(item.Value == "No category")
                    continue;
                listBoxCategories.Items.Add(item.Value);
            }
        }
        private void ManageCategoriesForm_Load(object sender, EventArgs e)
        {
            PopulateListBoxCategories();
        }
        private void buttonAddEditCategory_Click(object sender, EventArgs e)
        {
            string userInput = textBoxNewCategory.Text;

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Category name is invalid.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            if (_manager.CategoryNameExists(userInput))
            {
                MessageBox.Show("Category name is already in use.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            if (_isEditingCategory)
            {
                _manager.TryGetCategoryId(_categoryEditing,out Guid categoryId);
                _manager.RenameCategory(categoryId, textBoxNewCategory.Text);
            }
            else
            {
                _manager.AddCategory(userInput);
            }
            ResetAllControls();
            PopulateListBoxCategories();
        }
        private void textBoxNewCategory_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNewCategory.Text))
            {
                buttonAddEditCategory.Enabled = false;
            }
            buttonAddEditCategory.Enabled = true;
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _categoryEditing = listBoxCategories.SelectedItem.ToString();
            listBoxCategories.Enabled = false;
            SetButtonEdit();
            textBoxNewCategory.Text = listBoxCategories.SelectedItem.ToString();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show($"Are you sure that you want to delete {listBoxCategories.SelectedItem}?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                _manager.TryGetCategoryId(listBoxCategories.SelectedItem.ToString(),out Guid categoryId);
                _manager.RemoveCategory(categoryId);
                PopulateListBoxCategories();
            }
        }
    }
}
