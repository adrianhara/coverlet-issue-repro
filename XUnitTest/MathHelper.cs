using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest
{
    public class MathHelper
    {
        public int Add(int a1, int b)
        {
            if (a1 < 0)
            {
                return 0;
            }

            return a1 + b;
        }
    }
}
