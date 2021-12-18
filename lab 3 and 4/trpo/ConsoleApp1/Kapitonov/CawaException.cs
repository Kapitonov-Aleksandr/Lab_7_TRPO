using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitonov
{
    class CawaException:Exception
    {
        public CawaException(string message) : base(message)
        {

        }
    }
}
