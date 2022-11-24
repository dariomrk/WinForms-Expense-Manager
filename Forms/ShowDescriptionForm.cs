using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            richTextBoxDescription.Text = _description;
        }
    }
}
