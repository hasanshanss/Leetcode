using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.Abstraction
{
    internal interface ITask<T>
    {
        protected T Do();
    }
}
