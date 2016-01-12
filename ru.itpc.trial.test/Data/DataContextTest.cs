using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using ru.itpc.trial.Models;
using ru.itpc.trial.Data;

namespace ru.itpc.trial.test.Data
{
    [TestFixture]
    public class DataContextTest
    {
        private DataContext dataContext;

        [SetUp]
        public void setUp()
        {
            this.dataContext = new StorageDataContext();
        }

        [Test]
        public void Get_IEnumerable_test()
        {
            IEnumerable<PersonRecord> personRecords = 
                this.dataContext.Get<IEnumerable<PersonRecord>>();
            IEnumerable<IPerson> persons = 
                this.dataContext.Get<IEnumerable<IPerson>>();

            Assert.AreSame(personRecords, persons);

            Assert.NotNull(personRecords);
            Assert.NotNull(persons);

            Assert.AreEqual(0, personRecords.Count());
            Assert.AreEqual(0, persons.Count());
        }

        [Test]
        public void Get_ICollection_test()
        {
            ICollection<PersonRecord> persons = 
                this.dataContext.Get<ICollection<PersonRecord>>();

            Assert.NotNull(persons);
            Assert.AreEqual(0, persons.Count());
        }

        [Test]
        public void StorageDataContext_contains_DriverLicenses_test()
        {
            Assert.NotNull(this.dataContext.Get<List<DriverLicenseRecord>>());
            Assert.AreEqual(0, this.dataContext.Get<List<DriverLicenseRecord>>().Count);
        }

        [Test]
        public void StorageDataContext_contains_List_of_strings_test()
        {
            Assert.NotNull(this.dataContext.Get<List<string>>());
            Assert.AreEqual(0, this.dataContext.Get<List<string>>().Count);
        }

        [Test]
        public void StorageDataContext_contains_List_of_integers_test()
        {
            Assert.NotNull(this.dataContext.Get<ICollection<int>>());
            Assert.AreEqual(0, this.dataContext.Get<IEnumerable<int>>().Count());
        }

        [Test]
        public void StorageDataContext_store_LastChange_date_test()
        {
            Assert.LessOrEqual(this.dataContext.Get<DateTime>(), DateTime.Now);
        }
    }
}
