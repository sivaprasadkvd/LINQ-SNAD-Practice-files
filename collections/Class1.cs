using System.Collections;

namespace collections
{
    public class Employee
    {
        public int eno;
        public string ename;

        public Employee(int no, string name)
        {
            eno = no;
            ename = name;
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(new Employee(101, "siva"));
            ar.Add(new Employee(102, "prasad"));
            ar.Add(new Employee(103, "mahesh"));


            foreach (Employee item in ar)
            {
                Employee emp = (Employee)item;
                Console.WriteLine(emp.eno + emp.ename);
            }


        }
    }
}
