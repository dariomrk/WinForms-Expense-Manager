using System.Xml.Xsl;

namespace WinForms_Expense_Manager.Forms
{
    public partial class OptionsForm : Form
    {
        private Classes.ExpenseManager _manager;
        public OptionsForm(Classes.ExpenseManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            textBoxCurrency.Text = _manager.CurrencySign;
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCurrency.Text))
            {
                MessageBox.Show("Currency cannot be empty.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            if (textBoxCurrency.Text.Length != 3 && textBoxCurrency.Text.Length != 1)
            {
                MessageBox.Show("Currency has to be in one of the following formats:" +
                    " $, USD, €, EUR...",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            _manager.CurrencySign = textBoxCurrency.Text;
            this.Close();
        }

        private void textBoxCurrency_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxCurrency.Text;
            textBoxCurrency.Text = text.ToUpper();
            textBoxCurrency.SelectionStart = textBoxCurrency.Text.Length;
            textBoxCurrency.SelectionLength = 0;
        }
    }
}
