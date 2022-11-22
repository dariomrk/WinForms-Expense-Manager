using System.Text.Json.Serialization;
using System.Text.Json;
using WinForms_Expense_Manager.Schemas;
using System.Reflection;

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
        /// <summary>
        /// Populates the Expense Manager instance with the data from the "expense-manager-data.json" file, if available.
        /// </summary>
        public ExpenseManager()
        {
            var loading = LoadDataAsync();
            loading.Wait();
            if (!_categories.ContainsKey(Guid.Empty))
            {
                _categories.Add(Guid.Empty, "No category");
            }
        }
        #endregion

        #region Methods

        public bool CategoryExists(Guid id)
        {
            return _categories.ContainsKey(id);
        }

        public bool CategoryNameExists(string categoryName)
        {
            foreach (var c in _categories)
            {
                if (c.Value == categoryName)
                {
                    return true;
                }
            }
            return false;
        }

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

        public bool TryGetCategoryName(Guid id, out string? categoryName)
        {
            return _categories.TryGetValue(id, out categoryName);
        }


        /// <summary>
        /// Asynchronously saves all data to a file.
        /// </summary>
        private async Task SaveDataAsync()
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
        private async Task<bool> LoadDataAsync()
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

        public void AddTask(Entry e)
        {
            if(!_categories.ContainsKey(e.CategoryId))
                throw new ArgumentException("Category ID is not registered within the Expense Manager instance.");
            _entries.Add(e);
        }

        public Guid AddNewTask(string title, string description, decimal value)
        {
            Entry e = new(title, description, value);
            AddTask(e);
            return e.Id;
        }

        public Guid AddCategory(string categoryName)
        {
            if(CategoryNameExists(categoryName))
                throw new ArgumentException("Category name is already registered within the Expense Manager instance.");
            Guid categoryId = Guid.NewGuid();
            _categories.Add(categoryId,categoryName);
            return categoryId;
        }


        #endregion
    }
}
