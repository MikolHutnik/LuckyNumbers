using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikolHutnikLuckyNumbersProject
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Display of JackPot Total.
                Console.WriteLine("JackPot total $1578900.00");
                //Variables used
                string greetingOne;
                greetingOne = "Please choose a starting number.";
                int lowNum;

                string greetingTwo;
                greetingTwo = "Please choose a ending number.";
                int highNum;

                string action;
               


                //Request for low start number.
                Console.WriteLine(greetingOne);
                lowNum = int.Parse(Console.ReadLine());

                //Request for high end number.
                Console.WriteLine(greetingTwo);
                highNum = int.Parse(Console.ReadLine());

                //Supposed to request six numbers from user and make sure the are within chosen start and end numbers.

                //Console.WriteLine("Please Choose 6 numbers within starting and ending numbers already chosen.");
                //int[] chosenNum = new int[6];
                //for (int x = 0; x < chosenNum.Length; x++)
                //{


                //    if (int.Parse(Console.ReadLine()) < lowNum || int.Parse(Console.ReadLine()) > highNum)
                //    {
                //        Console.WriteLine("Please input valid number");

                //    }

                //}

                
                //Creates Random numbers printed in correct format.
                int[] Random = new int[6];
                Random r = new Random();
                for (int i = 0; i < Random.Length; i++)
                {

                    Random[i] = r.Next(lowNum, highNum);
                    Console.WriteLine("Lucky Number: {0}", Random[i]);

                }
                Console.WriteLine("Would you like to play again?");
                action = Console.ReadLine();
            }
             
             while (action != "yes");

        }//Main
    }//Class
}//Namespace
