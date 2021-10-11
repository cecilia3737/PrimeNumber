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
                //PrintMenu();

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
                        //MenuError();
                        break;
                }

            }


        }

        static void PrintMenu()
        {

        }

        static void SearchPrime()
        {

        }

        static void ListPrime()
        {

        }

    }
}
