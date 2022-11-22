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
    }
}