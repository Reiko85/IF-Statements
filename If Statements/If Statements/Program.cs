using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Tere Maailm");
            Console.ReadLine();
            string firstName;
            string lastName;
            
            int yearofBirth;




            Console.WriteLine("Mis on sinu nimi?");
            firstName = Console.ReadLine();
            Console.WriteLine("Mis on sinu perekonnanimi");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter your year of birth");
            yearofBirth = Int32.Parse(Console.ReadLine());






            Console.WriteLine($"Tere Tulemast, {firstName} {lastName}");
            Console.WriteLine($"Sa oled {2019 - yearofBirth} aastat vana");
            Console.ReadLine();*/

            /*Start:
            int userNumber;
            Console.WriteLine("Enter a number from 1 to 10");
            userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber < 5)
            {
                Console.WriteLine($"{userNumber} is less than 5");
                

            }
            else if (userNumber > 5)
               
            {
                Console.WriteLine($"{userNumber} is more than 5");

            }
            else if (userNumber == 5)
                    {
                Console.WriteLine($"{userNumber} equals 5.");


            }

            Console.ReadLine();

            goto Start;*/

          
             int userNumber;
            Console.WriteLine("Enter a number from 1 to 10");
            userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber >= 1 && userNumber <= 10)
            {
                if (userNumber < 5)
                {
                    Console.WriteLine($"{userNumber} is less than 5");
                }
                else if (userNumber > 5)
                {
                    Console.WriteLine($"{userNumber} is more than 5");
                }
                else
                {
                    Console.WriteLine($"{userNumber} equals to 5.");
                }
            }

            else
               {
                Console.WriteLine($"{userNumber} does not belong to the interval from 1 to 0");
               }
            
            

                
        Console.ReadLine();
            











        }
    }
}
