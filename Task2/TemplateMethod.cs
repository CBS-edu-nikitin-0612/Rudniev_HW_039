using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public override void TemplateMethod()
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
