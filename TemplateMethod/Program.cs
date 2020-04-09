using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClass = new ConcreteClassA();
            abstractClass.TemplateMethod();

            AbstractClass abstractClass1 = new ConcreteClassB();
            abstractClass1.TemplateMethod();


            Console.ReadKey();
        }
    }
}
