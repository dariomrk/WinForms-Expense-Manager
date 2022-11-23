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
        public readonly string DataFileName = "expense-manager-data.json";
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
        public ExpenseManager()
        {
            _categories.Add(Guid.Empty, "No category");
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
            if(data == null || data.Entries == null || data.Categories == null)
            {
                return false;
            }
            _entries = new List<Entry>(data.Entries);
            _categories = new Dictionary<Guid,string>(data.Categories);
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

        public Entry[] EntriesFromRange(DateTime fromDate, DateTime toDate)
        {
            var selected = from s in _entries
                           where s.CreatedAt > fromDate && s.CreatedAt < toDate
                           select s;
            return selected.ToArray();
        }


        #endregion
    }
}
