namespace LINQ_to_Collections
{
    class Employee
    {
        public int Eno { get; set; }
        public string Ename { get; set; }

        public int Dno { get; set; }

        public string Dname { get; set; }

        public string Designation { get; set; }

        public double Salary { get; set; }
    }
    public class A
    {

        public static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee(){ Eno=101, Ename="Anil", Salary = 20000, Dno =10 , Dname = "ECE" , Designation = "AsstProfessor" },
                new Employee(){ Eno=102, Ename="Sunil", Salary = 23000, Dno =10 , Dname = "ECE" , Designation = "AsstProfessor" },
                new Employee(){ Eno=103, Ename="junil", Salary = 24000, Dno =20 , Dname = "CSE" , Designation = "Professor" },
                new Employee(){ Eno=104, Ename="konil", Salary = 30000, Dno =10 , Dname = "ECE" , Designation = "AsstProfessor" },
                new Employee(){ Eno=105, Ename="gonil", Salary = 26000, Dno =20 , Dname = "CSE" , Designation = "Professor" },
                new Employee(){ Eno=106, Ename="ronil", Salary = 21000, Dno =10 , Dname = "ECE" , Designation = "AsstProfessor" },

            };

            //=================== Waq to display all Employee details ============================== 

            Console.WriteLine("Waq to display all Employee details");
            Console.WriteLine("Eno" + "\t" + "Ename" + "\t" + "Salary" + "\t" + "Dno" + "\t" + "Dname" + "\t" + "Designation");

            var q1 = from x in emps
                     select x;

            foreach (var item in q1)
            {
                Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary + "\t" + item.Dno + "\t" + item.Dname + "\t" + item.Designation);
            }

            //=================== waq to display eno,ename,salary working in dno 10 ==============================

            Console.WriteLine("waq to display eno,ename,salary working in dno 10");
            Console.WriteLine("Eno" + "\t" + "Ename" + "\t" + "Salary");

            var q2 = from x in emps
                     where x.Dno == 10
                     select x;

            foreach (var item in q2)
            {
                Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary);
            }

            //=================== Waq to display Employees whose salary is >25000 ============================== 

            Console.WriteLine("Waq to display Employees whose salary is >23000");
            Console.WriteLine("Eno" + "\t" + "Ename" + "\t" + "Salary" + "\t" + "Dno" + "\t" + "Dname" + "\t" + "Designation");

            var q3 = from x in emps
                     where x.Salary > 23000
                     select x;

            foreach (var item in q3)
            {
                Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary + "\t" + item.Dno + "\t" + item.Dname + "\t" + item.Designation);
            }

            //================= Waq to display Employees who is working in department ECE and salary is >25000 ============================== 

            Console.WriteLine("Waq to display Employees who is working in department ECE and salary is >25000");
            Console.WriteLine("Eno" + "\t" + "Ename" + "\t" + "Salary" + "\t" + "Dno" + "\t" + "Dname" + "\t" + "Designation");

            var q4 = from x in emps
                     where x.Dname == "ECE" && x.Salary > 23000
                     select x;

            foreach (var item in q4)
            {
                Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary + "\t" + item.Dno + "\t" + item.Dname + "\t" + item.Designation);
            }


            //================= waq to display Employees in ascending order based on salary ============================== 

            Console.WriteLine("waq to display Employees in ascending order based on salary");
            Console.WriteLine("Eno" + "\t" + "Ename" + "\t" + "Salary" + "\t" + "Dno" + "\t" + "Dname" + "\t" + "Designation");

            var q5 = from x in emps
                     orderby x.Salary ascending
                     select x;

            foreach (var item in q5)
            {
                Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary + "\t" + item.Dno + "\t" + item.Dname + "\t" + item.Designation);
            }

            //================= waq to display Employees in ascending order based on salary and who is working in department ECE ============================== 

            Console.WriteLine("waq to display Employees in ascending order based on salary and who is working in department ECE");
            Console.WriteLine("Eno" + "\t" + "Ename" + "\t" + "Salary" + "\t" + "Dno" + "\t" + "Dname" + "\t" + "Designation");

            var q6 = from x in emps
                     where x.Dname == "ECE"
                     orderby x.Salary ascending
                     select x;

            foreach (var item in q6)
            {
                Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary + "\t" + item.Dno + "\t" + item.Dname + "\t" + item.Designation);
            }

            //================= waq to display top 3 of Employees who taking high salary ============================== 

            Console.WriteLine("waq to display top 3 of Employees who taking high salary ");
            Console.WriteLine("Eno" + "\t" + "Ename" + "\t" + "Salary" + "\t" + "Dno" + "\t" + "Dname" + "\t" + "Designation");

            var q7 = (from x in emps
                      orderby x.Salary descending
                      select x).Take(3);

            foreach (var item in q7)
            {
                Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary + "\t" + item.Dno + "\t" + item.Dname + "\t" + item.Designation);
            }

            //================= waq to display Employees except top 2 salaries ============================== 

            Console.WriteLine("waq to display Employees except top 2 salaries ");
            Console.WriteLine("Eno" + "\t" + "Ename" + "\t" + "Salary" + "\t" + "Dno" + "\t" + "Dname" + "\t" + "Designation");

            var q8 = (from x in emps
                      orderby x.Salary descending
                      select x).Skip(2);

            foreach (var item in q8)
            {
                Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary + "\t" + item.Dno + "\t" + item.Dname + "\t" + item.Designation);
            }


            //================= waq to display 4th Max salary of Employees ============================== 

            Console.WriteLine("waq to display 4th Max salary of Employees ");
            Console.WriteLine("Eno" + "\t" + "Ename" + "\t" + "Salary" + "\t" + "Dno" + "\t" + "Dname" + "\t" + "Designation");

            var q9 = (from x in emps
                      orderby x.Salary descending
                      select x).Take(4).Skip(3);

            foreach (var item in q9)
            {
                Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary + "\t" + item.Dno + "\t" + item.Dname + "\t" + item.Designation);
            }




            Console.Read();


        }
    }
}

