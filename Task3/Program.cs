using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What`s your number?");
            string UserInput = Console.ReadLine();
            int Number = Int32.Parse(UserInput);

            if (Number > 0)
            {

                Console.WriteLine("The number is positive.");
            }else if (Number < 0)
            {


                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is 0.");
            }






        }
    }
}
