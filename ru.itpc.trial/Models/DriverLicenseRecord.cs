using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Models
{
    public class DriverLicenseRecord : IDriverLicense
    {
        #region Fields

        public int Id { get; private set; }

        public string Class { get;  set; }

        public DateTime Expires { get; set; }

        public DateTime Issued { get; set; }

        public DateTime OwnerBirthDate { get; set; }

        public string OwnerFirstName { get; set; }

        public string OwnerLastName { get; set; }

        #endregion

        #region Constructors

        public DriverLicenseRecord(int id, string licenseClass, DateTime expiration, PersonRecord person)
        {
            this.Id = id;
            this.Class = licenseClass;
            this.Expires = expiration;
            this.OwnerFirstName = person.FirstName;
            this.OwnerLastName = person.LastName;
            this.OwnerBirthDate = person.BirthDate;
        }

        #endregion

        #region Methods

        #endregion
    }
}
