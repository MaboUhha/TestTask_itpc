using ru.itpc.trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Data
{
    public class StorageDataContext:DataContext
    {
        public List<PersonRecord> PersonRecords { get; set; }
        public List<DriverLicenseRecord> DriversLicensesRecords { get; set; }
        public List<string> Strings { get; set; }
        public List<int> Integers { get; set; }
        public DateTime LastChange { get; set; }

        public StorageDataContext()
        {
            this.PersonRecords = new List<PersonRecord>();
            this.DriversLicensesRecords = new List<DriverLicenseRecord>();
            this.Strings = new List<string>();
            this.Integers = new List<int>();
            this.LastChange = DateTime.Now;
        }

        public T Get<T>()
        {
            foreach (PropertyInfo property in this.GetType().GetProperties())
            {
                if (typeof(T).IsAssignableFrom(property.PropertyType))
                    return (T)property.GetValue(this);
            }
            return default(T);
        }

    }

    public class DefaultDataContext
    {
        static StorageDataContext dataContext = new StorageDataContext();
        
        public static DataContext Instance { get { return dataContext; } }

        private DefaultDataContext() { }
    }
}
