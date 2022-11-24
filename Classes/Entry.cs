using System.Text.Json.Serialization;

namespace WinForms_Expense_Manager.Classes
{
    /// <summary>
    /// Represents a single income / expense entry.
    /// </summary>
    public class Entry
    {
        #region Properties
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public Guid CategoryId { get; set; }

        [JsonIgnore]
        public bool IsExpense
        {
            get
            {
                return Value < 0;
            }
        }
        [JsonIgnore]
        public bool IsIncome
        {
            get
            {
                return Value > 0;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new Entry object.
        /// </summary>
        public Entry(string title = "", string description = "", decimal value = 0m)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            Title = title;
            Description = description;
            Value = value;
            CategoryId = Guid.Empty;
        }
        /// <summary>
        /// Creates an Entry object.
        /// </summary>
        [JsonConstructor]
        public Entry(Guid id, DateTime createdAt, string title, string description, decimal value, Guid categoryId)
        {
            Id=id;
            CreatedAt=createdAt;
            Title=title;
            Description=description;
            Value=value;
            CategoryId=categoryId;
        }
        #endregion
    }
}
