using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your year of birth?");
            int YearOfBirth;
            int Age;
            string UserInput;
            UserInput = Console.ReadLine();
            YearOfBirth = Int32.Parse(UserInput);
            Age = 2020 - YearOfBirth;

            if (Age < 18)
            {
                Console.WriteLine($"you are {Age}, you are too young.");
            } else if (Age > 18)
            {
                Console.WriteLine($"you are {Age}, you are old enough.");
            }
             else
            {
                Console.WriteLine($"Congratulations! you are {Age}");
                Console.WriteLine("What is your first nnumber");
                string U  = Console.ReadLine();
                int Num1 = Int32.Parse(UserInput);
                Console.WriteLine("What is your second number?");
                UserInput = Console.ReadLine();
                int Num2 = Int32.Parse(UserInput);

                if (Num1 == Num2)
                {
                    Console.WriteLine("The numbers you provided are equal");
                }
                else
                {
                    Console.WriteLine("the numbers you provided are NOT equal");
                }
                


                    
                
            }
        }
    }
}
