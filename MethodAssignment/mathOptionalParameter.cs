using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class mathOptionalParameter
            {
            // Method to perform a math operation on two integers
            // 'b' is the optional 
            public int MathOp(int a, int b = 0)
            {
                // addition of the integers
                int result = a + b;
                return result;
            }
        }

    
}
