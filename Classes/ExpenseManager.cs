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
        public readonly string DataFileName = "expense-manager-data.json";
        private List<Entry> _entries = new();
        private Dictionary<Guid, string> _categories = new()
        {
            {Guid.Empty, "No category"},
        };
        private string _currencySign = "$";
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
        [JsonInclude]
        public string CurrencySign 
        { 
            get => _currencySign;
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                _currencySign = value;
            }
        }
        #endregion

        #region Constructors
        public ExpenseManager()
        {

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

        public void SaveData()
        {
            string data = JsonSerializer.Serialize<ExpenseManager>(this,
                new JsonSerializerOptions { WriteIndented = true }
                );

            using StreamWriter sw = new(DataFileName);
            sw.Write(data);
        }

        public bool LoadData()
        {
            if (!File.Exists(DataFileName))
                return false;
            using StreamReader sr = new(DataFileName);
            string json = sr.ReadToEnd();

            ExpenseManagerDataSchema? data = JsonSerializer.Deserialize<ExpenseManagerDataSchema>(json);
            if(data == null || data.Entries == null || data.Categories == null || data.CurrencySign == null)
            {
                return false;
            }
            _entries = new List<Entry>(data.Entries);
            _categories = new Dictionary<Guid,string>(data.Categories);
            CurrencySign = data.CurrencySign;
            return true;
        }

        public void AddEntry(Entry e)
        {
            if(!_categories.ContainsKey(e.CategoryId))
                throw new ArgumentException("Category ID is not registered within the Expense Manager instance.");
            _entries.Add(e);
        }

        public Guid AddNewEntry(string title, string description, decimal value)
        {
            Entry e = new(title, description, value);
            AddEntry(e);
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
        
        public bool TryFindEntry(Guid id, out Entry e)
        {
            e = null;
            foreach(var entry in _entries)
            {
                if(entry.Id == id)
                {
                    e = entry;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveEntry(Guid id)
        {
            TryFindEntry(id, out Entry e);
            return _entries.Remove(e);
        }
        #endregion
    }
}
