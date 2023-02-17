using System.Runtime.InteropServices;

namespace NetTuplesRecordsApp
{
    class UserC
    {
        public string Name { set; get; }
        public int Age { set; get; }
    }

    struct UserS
    {
        public string Name { set; get; }
    }

    record UserR
    {
        public string Name { set; get; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            UserC user = new UserC() { Name = "Joe", Age = 23 };
            
            var person = new { Name = "Bob", Age = 34 };

           
        }

        static void RecordExample()
        {
            UserC u1 = new() { Name = "Bob" };
            UserC u2 = new() { Name = "Bob" };
            Console.WriteLine(u1.Equals(u2));

            UserS u3 = new() { Name = "Bob" };
            UserS u4 = new() { Name = "Bob" };
            Console.WriteLine(u3.Equals(u4));

            UserR u5 = new() { Name = "Bob" };
            UserR u6 = new() { Name = "Bob" };
            Console.WriteLine(u5.Equals(u6));
        }
        static void TupleExample()
        {
            var tuple = (10, 20);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);

            tuple.Item1 += 30;

            var user = (name: "Bob", age: 23, city: "Mocow");
            Console.WriteLine(user.name);
            Console.WriteLine(user.age);

            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(100);
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);
                }
            }
        }
        static void PrintTuple((string, string) tuple)
        {
            Console.WriteLine(tuple.Item1 + " " + tuple.Item2);
        }



    }
}