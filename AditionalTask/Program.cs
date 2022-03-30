using System;

namespace AditionalTask
{
    class Base
    {
        public void TemplateMethod()
        {
            this.Method1();
            this.Method2();
        }
        protected virtual void Method1()
        {
            Console.WriteLine("Method1...");
        }
        protected virtual void Method2() { }
    }
    class Derived : Base
    {
        protected override void Method2()
        {
            Console.WriteLine("Method2...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base instance = new Derived();
            instance.TemplateMethod();
        }
    }
}
