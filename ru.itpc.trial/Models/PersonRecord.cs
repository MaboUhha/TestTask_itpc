using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Models
{
    public class PersonRecord : IPerson, IIdentified<string>
    {
        #region Fields

        public string Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime BirthDate { get; private set; }

        #endregion

        #region Constructors

        public PersonRecord(string firstName, string lastName)
        {
            this.Id = String.Format(@"{0}", Guid.NewGuid());
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        #endregion

        #region Methods



        #endregion

    }
}
