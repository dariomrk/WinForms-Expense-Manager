using WinForms_Expense_Manager.Classes;

namespace WinForms_Expense_Manager.Schemas
{
    /// <summary>
    /// Defines the ExpenseManager data schema.
    /// </summary>
    public class ExpenseManagerDataSchema
    {
        public List<Entry>? Entries { get; set; }
        public Dictionary<Guid, string>? Categories { get; set; }
    }
}
