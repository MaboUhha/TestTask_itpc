using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Data
{
    public interface DataContext
    {
        T Get<T>();
    }
}
