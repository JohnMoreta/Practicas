using System;

namespace Practica3
{
    public class A
    {
        public A()
        {
            Console.WriteLine("Constructor Clase A");
        }
    }
    public class B : A
    {
        public B()
        {
            Console.WriteLine("Constructor Clase B");
        }
    }
    public class C : B
    {
        public C()
        {
            Console.WriteLine("Constructor Clase C");
        }
    }
    class Objeto
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
            Console.ReadKey();
        }
    }
}