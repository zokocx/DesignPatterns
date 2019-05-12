using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ObserverConcrete : IObserver
    {
        private string _name;

        public ObserverConcrete(string name)
        {
            _name = name;
        }

        public void Update(Subject subject)
        {
            if (subject is SubjectConcrete)
            {
                Console.WriteLine("Notified {0} of {1}'s " + " values are '{2}' and '{3}'.", _name, subject.GetType().Name, subject.SomeValue, subject.SomeOtherValue);
            }
        }
    }
}
