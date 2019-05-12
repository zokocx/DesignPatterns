using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new SubjectConcrete(10, "test");
            subject.Attach(new ObserverConcrete("observer_1"));
            subject.Attach(new ObserverConcrete("observer_2"));
            subject.Attach(new ObserverConcrete("observer_3"));

            subject.SomeValue = 11;
            subject.SomeOtherValue = "new Test";
            Console.WriteLine("Notify all at once!");
            subject.Notify();

            Console.WriteLine();
            Console.WriteLine("Change to AutoNotify at property change!");
            subject.AutoNotify = true;
            Console.WriteLine("Update some value!");
            subject.SomeValue = 12;

            Console.WriteLine();
            Console.WriteLine("Update some other value!");
            subject.SomeOtherValue = "blahblah";

            Console.ReadKey();
        }
    }
}
