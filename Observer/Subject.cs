using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        public bool AutoNotify { get; set; } = false;
        private bool changed = false;

        private decimal someValue;
        private string someOtherValue;

        public decimal SomeValue
        {
            get { return someValue; }
            set
            {
                if(someValue != value)
                {
                    someValue = value;
                    changed = true;
                    NotifyFromProperty();
                }
            }
        }

        public string SomeOtherValue
        {
            get { return someOtherValue; }
            set
            {
                if (someOtherValue != value)
                {
                    someOtherValue = value;
                    NotifyFromProperty();
                }
            }
        }

        #region Ctor

        public Subject(decimal someValue, string someOtherValue)
        {
            this.someValue = someValue;
            this.someOtherValue = someOtherValue;
        }

        #endregion

        private void NotifyFromProperty()
        {
            changed = true;
            if (AutoNotify)
                Notify();
        }

        public void Attach(IObserver observer) => observers.Add(observer);

        public void Detach(IObserver observer) => observers.Remove(observer);

        public void Notify()
        {
            if (changed)
            {
                foreach (IObserver observer in observers)
                {
                    observer.Update(this);
                }
                changed = false;
            }

            Console.WriteLine("Notified all observers: {0}", observers.Count);
        }
    }
}
