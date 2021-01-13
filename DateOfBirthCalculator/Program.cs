using System;

namespace DateOfBirthCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("enter your age \n");

            string age = Console.ReadLine();

            DateTime now = DateTime.Now;
            

            int birth = 2021 - int.Parse(age);

            Console.WriteLine("\n your date of birth is: " + birth);

            
        }
    }
}
