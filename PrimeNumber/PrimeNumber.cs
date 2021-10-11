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

            while (run)
            {
                PrintMenu();

                string menuInput = Console.ReadLine();

                switch (menuInput) 
                { 
                
                    case "1":
                        //SearchPrime();
                        break;
                    case "2":
                        //ListPrime();
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
                    "1. Search for prime\n" +
                    "2. Show list of prime\n" +
                    "3. Quit\n" +
                    "----------");
            Console.WriteLine("Enter your choice:");
        }

        static void SearchPrime()
        {

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

    }
}
