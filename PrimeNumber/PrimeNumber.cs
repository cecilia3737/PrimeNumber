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
                        ListPrime(primeList);
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

        //Simply prints the startmenu
        private static void PrintMenu()
        {
            Console.WriteLine("" +
                    "1. Search for a prime number\n" +
                    "2. Show list of prime numbers\n" +
                    "3. Quit\n");
            Line();
            Console.WriteLine("Enter your choice:");
        }

        /*Accept an interger input from user,
          If input is not a prime number: it will print an error message saying so.
          If input is a prime number: it will print a message and proceed to add the number to a list of Prime numbers if the number is not in list.
          If input is invalid: it will print an error and asks for a new input*/
        private static void SearchPrime(List<int> list)
        {
            bool runPrimeSearch = true;

            Line();
            Console.WriteLine("Enter a number:");

            while (runPrimeSearch)
            {
                string input = Console.ReadLine();
                Line();

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
                    Console.WriteLine("Wrong input, Please enter a number(integer)");
                }
            
            }

            Line();

        }

        /*When active,this method will sort and print out the list of prime numbers, if the list contains any.
          If the list is empty: it will print out a error message and go back to main menu
          Then it will ask the user if they want to automagically add the next prime number to the list*/
        private static void ListPrime(List<int> list)
        {
            Line();
            list.Sort();

            if (list.Any())
            {
                foreach (var prime in list)
                {
                    Console.WriteLine(prime);
                }

                AddNextPrimeNumber(list);

                Line();

            }

            else
            {
                Console.WriteLine("List of prime numbers is empty, add numbers to the list by searching");
                Line();
            }
        }

        //Error message if user enter wrong input in startmenu
        private static void MenuError()
        {
            Line();
            Console.WriteLine("Wrong input, Enter a number between 1-3");
            Line();
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

        /*This method asks if user want to add the next prime number in the prime number-list.
          If yes: the program will find the largest number in list, and then search for the next 
          number between the largest number + 1 up to largest number + 100
          It will then add the next number and return to start menu
          If no: It will return to start menu
          Invalid input: If userinput is other then y or n it will show a error message.*/
        private static void AddNextPrimeNumber(List<int> list)
        {
            Line();
            Console.WriteLine("Want to add the next prime number? y/n");

            bool nextPrimeRun = true;

            while (nextPrimeRun)
            {

                string input2 = Console.ReadLine();

                if (input2.ToLower() == "y")
                {
                    int maxPrime = list.Last();

                    for (int i = maxPrime + 1; i < maxPrime + 100; i++)
                    {
                        if (CheckIfPrime(i))
                        {
                            list.Add(i);
                            break;
                        }
                    }
                    nextPrimeRun = false;
                }

                else if (input2 == "n")
                {
                    nextPrimeRun = false;
                    break;
                }

                else
                {
                    Console.WriteLine("Wrong input, enter y/n");
                }
            }
        }

        //Decoration-divider
        private static void Line()
        {
            Console.WriteLine("----------");
        }

    }
}
