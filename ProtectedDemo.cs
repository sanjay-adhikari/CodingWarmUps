using System;

namespace ProtectedDemo
{
    class A
    {
        protected int x = 123;
    }
    class C : A
    { 
    }
    class B : C
    {
        static void Main(string[] args)
        {
            var a = new A();
            var b = new B();
            var c = new C();

            // Error CS1540, because x can only be accessed by
            // classes derived from A.
             a.x = 10; //error
             c.x = 10; //error
            
            b.x = 10;  // OK, because this class derives from A.
        }
    }

}
