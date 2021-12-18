using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLAB1
{
    class Program
    {
        public int a
        {
            get { return a; }
            set { a = value; }
        }
        public int b
        {
            get { return b; }
            set { b = value; }
        }
        public int c
        {
            get { return c; }
            set { c = value; }
        }

        class A
        {

        }
        class B : A
        {
            public object a;
            public object b;
        }
        class C : B
        {
            public object c;
        }

        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();
            A a4 = new A();
            B b5 = new B();
            b5.a = a3;
            b5.a = a4;

            C c6 = new C();
            c6.a = a1;
            c6.a = a2;
            c6.b = b5;

        }
    }
}
