using System;

namespace Delegates___Events
{
    public delegate void myDelegate();
    class A
    {
        public static event myDelegate myEvent1;

        public static void M1()
        {
            Console.WriteLine("I am M1");
        }

        public static void M2()
        {
            Console.WriteLine("I am M2");
        }

        public static void Main(String[] args)
        {
            myDelegate DO = new myDelegate(M1);
            DO += new myDelegate(M2);
            DO();
            Console.Read();
        }

        //================================================================


        //public static event myDelegate myEvent1;

        //public static void Main(String[] args)
        //{
        //    myEvent1 += delegate()
        //    {

        //        Console.WriteLine("I am ananomous function");

        //    };

        //    myEvent1();
        //}

    }
}

