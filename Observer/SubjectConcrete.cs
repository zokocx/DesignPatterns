using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class SubjectConcrete : Subject
    {
        public SubjectConcrete(decimal someValue, string someOtherValue) : base(someValue, someOtherValue)
        {
        }
    }
}
