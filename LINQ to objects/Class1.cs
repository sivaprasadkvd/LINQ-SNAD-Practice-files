namespace LINQ_to_objects
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //prepare the datasource
            int[] Ar = new int[6] { 2, 3, 4, 5, 6, 10 };

            //waq to display the values from Array
            var q1 = from x in Ar
                     select x;

            //Execute the query
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            //============== waq to display the even numbers from Array =============================================

            var q2 = from x in Ar
                     where x % 2 == 0
                     select x;

            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }

            //============== waq to display the numbers >5 from Array ===============================================

            var q3 = from x in Ar
                     where x > 5
                     select x;

            foreach (var item in q3)
            {
                Console.WriteLine(item);
            }

            //============== waq to display Array elements in decending ===============================================

            var q4 = from x in Ar
                     orderby x descending
                     select x;

            foreach (var item in q3)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
