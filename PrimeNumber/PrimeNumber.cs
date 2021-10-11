using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class PrimeNumber
    {
        public void PrimeNumberProgram()
        {
            List<int> primeList = new List<int>();

            bool run = true;

            //Runs startmenu until user quits
            while (run)
            {
                PrintMenu();

                string menuInput = Console.ReadLine();

                switch (menuInput) 
                { 
                
                    case "1":
                        SearchPrime(primeList);
                        break;
                    case "2":
                        //ListPrime(primeList);
                        break;
                    case "3":
                        run = false;
                        break;
                    default:
                        MenuError();
                        break;
                }

            }

        }

        static void PrintMenu()
        {
            Console.WriteLine("" +
                    "1. Search for a prime number\n" +
                    "2. Show list of prime numbers\n" +
                    "3. Quit\n" +
                    "----------");
            Console.WriteLine("Enter your choice:");
        }

        /*Accept an interger input from user, If input is invalid, it will print an error and asks for a new input
          If input is not a prime number, it will print an error message saying so.
          If input is a prime number it will print a message and proceed to add the number to a list of Prime numbers)*/
        static void SearchPrime(List<int> list)
        {
            bool runPrimeSearch = true;

            Console.WriteLine("---------- \n" +
                              "Enter a number:");

            while (runPrimeSearch)
            {
                string input = Console.ReadLine();
                Console.WriteLine("----------");

                int num;

                if(int.TryParse(input, out num))
                {
                    if (CheckIfPrime(num))
                    {
                        Console.WriteLine($"{num} is a prime number");

                        if (!list.Contains(num))
                        {
                            list.Add(num);
                        }

                    }

                    else
                    {
                        Console.WriteLine($"{num} is not a prime number");
                    }

                    runPrimeSearch = false;

                }

                else
                {
                    Console.WriteLine($"Wrong input, Please enter a number");
                }
            
            }

            Console.WriteLine("----------");

        }

        static void ListPrime()
        {

        }

        //Error message if user enter wrong input in startmenu
        static void MenuError()
        {
            Console.WriteLine("---------- \n" +
                    "Wrong input, Enter a number between 1-3 \n" +
                    "----------");
        }

        /*Algoritm that checks if number is prime or not.
          First it checks if a input is 1 or less - Can't be a primenumber if so.
          i is the numbers between 2 and input divided by 2.
          If there are remainder when input is divided by any of numbers i, then it will show up true (It is a prime number), 
          if zero remainder it will show up false.*/
        private static bool CheckIfPrime(int input)
        {

            var isPrime = true;

            if (input <= 1)
            {
                return false;
            }

            for (int i = 2; i <= input / 2; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }

    }
}
