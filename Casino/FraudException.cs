using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException() //these are both constructors that implement the same things as Exception
            :  base() { }
        public FraudException(string message) //this is an overload
            : base(message) { }
    }
}
