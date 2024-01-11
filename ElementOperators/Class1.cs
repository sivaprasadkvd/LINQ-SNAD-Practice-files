using System.ComponentModel;

namespace ElementOperators
{
    class Employee
    {
        public int Eno { get; set; }

        public string Ename { get; set; }
    }

    class A
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee(){Eno= 101 , Ename = "Anil"},
                new Employee(){Eno= 102 , Ename = "Sunil"},
                new Employee(){Eno= 103 , Ename = "Ajay"},

            };

            // find first employee in emps collection

            Employee e1 = emps.First();
            Console.WriteLine(e1.Eno + e1.Ename);

            // find first employee in emps collection where eno = 103

            Employee e2 = emps.First( x => x.Eno == 103);
            Console.WriteLine(e2.Eno + e2.Ename);

        }
    }
}
/*
    public class A
    {
        public static void Main(string[] args)
        {
            int[] Ar = new int[5] { 1, 2, 3, 4, 5 };

            // find first number in Ar
            int i = Ar.First();
            Console.WriteLine(i);

            // find first even number in Ar

            int ev = Ar.First( x => x % 2 == 0 );
            Console.WriteLine(ev);

        }

    }*/