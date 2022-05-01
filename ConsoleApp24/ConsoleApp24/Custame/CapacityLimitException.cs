using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24.Custame
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {

        }
    }
}
