 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
       public static void Main(string[] args)
        {
            // single line statement
            Console.WriteLine("Hello mono World");

            int age = 23;
            Console.Write("age: ");
            Console.WriteLine(age );

            bool isRunning = false;
            Console.Write("is running: ");
            Console.WriteLine(isRunning);

            float weight = 100.12f;
            Console.Write("weight: ");
            Console.WriteLine(weight);

            double height = 1.75;
            Console.Write("height: ");
            Console.WriteLine(height);

            char bloodGroup = 'A';
            Console.Write("BloodGroup: ");
            Console.WriteLine(bloodGroup);

            string moto = "Good thinking, good product.";
            Console.Write("moto");
            Console.WriteLine(moto);

            const double pi = 3.14159;
            Console.Write("pi: ");
            Console.WriteLine(pi);
            Console.ReadKey(true);
     
        }
    }
}
