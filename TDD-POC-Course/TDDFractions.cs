using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MathExtension;


namespace TDD_POC_Course
{
    public class TDDFractions
    {
        public Rational AddFractions(Rational x, Rational y)
        {
            var retVal = x + y;
            return retVal;
        }
    }


}
