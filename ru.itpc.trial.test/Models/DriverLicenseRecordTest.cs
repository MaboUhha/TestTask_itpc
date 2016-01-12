using System;
using NUnit.Framework;
using ru.itpc.trial.Models;

namespace ru.itpc.trial.test.Models
{
    [TestFixture]
    public class DriverLicenseRecordTest
    {
        private PersonRecord person;

        [SetUp]
        public void setUp()
        {
            this.person = new PersonRecord("Jack", "Sparrow");
        }

        [Test]
        public void DriverLicenseRecord_construction_test()
        {
            int id = 3582737;
            string licenseClass ="F";
            DateTime expiration = new DateTime(2020, 1, 1);

            DriverLicenseRecord license =
                new DriverLicenseRecord(id, licenseClass, expiration, this.person);

            /// Identified и DriverLicense должны быть интерфейсами
            Assert.IsInstanceOf(typeof(IIdentified<int>), license);
            Assert.IsInstanceOf(typeof(IDriverLicense), license);

            Assert.AreEqual(id, license.Id);
            Assert.AreEqual(licenseClass, license.Class);
            Assert.AreEqual(expiration, license.Expires);
            Assert.LessOrEqual(license.Issued, DateTime.Now);

            Assert.AreEqual(this.person.FirstName, license.OwnerFirstName);
            Assert.AreEqual(this.person.LastName, license.OwnerLastName);
            Assert.AreEqual(this.person.BirthDate, license.OwnerBirthDate);
        }
    }
}
