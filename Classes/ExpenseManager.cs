using System.Text.Json.Serialization;
using System.Text.Json;
using WinForms_Expense_Manager.Schemas;

namespace WinForms_Expense_Manager.Classes
{
    /// <summary>
    /// Provides methods and properties to manipulate and access Entries,
    /// methods for saving and loading data, validation and more.
    /// </summary>
    public class ExpenseManager
    {
        #region Fields
        private readonly string _fileName = "expense-manager-data.json";
        private List<Entry> _entries = new();
        private Dictionary<Guid, string> _categories = new();
        #endregion

        #region Properties
        /// <summary>
        /// Provides a copy of the Entries stored in this object.
        /// </summary>
        [JsonInclude]
        public List<Entry> Entries { get => new(_entries); }
        /// <summary>
        /// Provides a copy of the Categories stored in the Expense Manager object.
        /// </summary>
        [JsonInclude]
        public Dictionary<Guid, string> Categories { get => new(_categories); }
        #endregion

        #region Constructors

        #endregion

        #region Methods
        public bool TryGetCategoryId(string categoryName, out Guid id)
        {
            foreach (var c in _categories)
            {
                if (c.Value == categoryName)
                {
                    id = c.Key;
                    return true;
                }
            }
            id = Guid.Empty;
            return false;
        }
        public bool CategoryExists(Guid id)
        {
            return _categories.ContainsKey(id);
        }
        public bool TryGetCategoryName(Guid id, out string? categoryName)
        {
            return _categories.TryGetValue(id, out categoryName);
        }
        /// <summary>
        /// Asynchronously saves all data to a file.
        /// </summary>
        /// <returns></returns>
        public async Task SaveDataAsync()
        {
            using FileStream stream = File.Create(_fileName);
            await JsonSerializer.SerializeAsync(stream, this, new JsonSerializerOptions { WriteIndented = true });
            await stream.DisposeAsync();
            return;
        }
        /// <summary>
        /// Asynchronously loads data from a file.
        /// </summary>
        /// <returns>Boolean indicating wether the loading was successful.</returns>
        public async Task<bool> LoadDataAsync()
        {
            if (!File.Exists(_fileName))
                return false;

            using FileStream stream = File.OpenRead(_fileName);
            ExpenseManagerDataSchema? data = await JsonSerializer.DeserializeAsync<ExpenseManagerDataSchema>(stream);

            if(data == null || data.Entries == null || data.Categories == null)
                return false;

            _entries = new List<Entry>(data.Entries);
            _categories = new Dictionary<Guid, string>(data.Categories);
            return true;
        }
        #endregion
    }
}
