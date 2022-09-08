using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.Abstraction
{
    internal abstract class StringBaseTask<RETURN_TYPE> : BaseTask<string, RETURN_TYPE>
    {
        protected StringBaseTask(string input) : base(input)
        {
            
        }

        protected override void ThrowIfEmpty()
        {
            if (String.IsNullOrEmpty(baseTaskParams.Input))
                throw new ArgumentNullException(nameof(baseTaskParams.Input));
        }
    }
}
