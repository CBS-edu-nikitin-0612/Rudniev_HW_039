using System;

namespace Task2
{
    public abstract class AbstractTemplateMethod
    {
        public virtual void TemplateMethod()
        {
            this.Method1();
            //add next method in derived class
        }
        protected abstract void Method1();
    }

    internal class MyClass : AbstractTemplateMethod
    {
        public sealed override void TemplateMethod()
        {
            base.TemplateMethod();
            this.Method2();
        }
        protected override void Method1()
        {
            Console.WriteLine("Method1...");
        }
        protected virtual void Method2()
        {
            Console.WriteLine("Method2...");
        }
    }
}
