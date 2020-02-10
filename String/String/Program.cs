//Ed Louie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //                  01 (Length minus 1)
            string firstName = "Edward";
            string lastName = "Louie";

            Console.WriteLine($"You have {firstName.Length.ToString("N0")} characters in your first name.");

            Console.WriteLine($"You have {lastName.Length.ToString("N0")} characters in your last name.");

            char firstInitial = firstName[0];
            char lastInitial = lastName[0];

            // Console.WriteLine(firstName.ToUpper()[0]);
            // Console.WriteLine(firstName.ToUpper()[1]);

            firstName = firstName.ToUpper();

            //i++ same as i = i + 1
            //Output every character of the firstname on a seperate line with BIG LETTERS

            foreach (var currentLetter in firstName)
            {
                Console.WriteLine(currentLetter);
            }

            /*for (int i = 0; i < firstName.Length; i++)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter);
            } */

            Console.WriteLine("Output every other letter of the first name");
            for (int i = 0; i < firstName.Length; i = i + 2)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter + " ");             
            }


            //Edward Louie
            //eiouL drawdE
            //Write your name backwards

            string name = firstName + " " + lastName;
            var pieces = name.Split(' '); //Creates collection with a size of 2
            string fName = name.Substring(0, firstName.Length);
            fName = "              " + fName + "          ";
            fName = fName.Trim();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }

            



            Console.WriteLine($"Your initials are {firstInitial}.{lastInitial}");


            Console.ReadKey();

        }
    }
}
