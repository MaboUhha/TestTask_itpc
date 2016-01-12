using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Models
{
    public interface IDriverLicense : IIdentified<int>
    {
        string Class { get; set; }
        DateTime Issued { get; set; }
        DateTime Expires { get; set; }
        string OwnerFirstName { get; set; }
        string OwnerLastName { get; set; }
        DateTime OwnerBirthDate { get; set; }
    }
}
