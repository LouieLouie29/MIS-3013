//Ed Louie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string named firstName
            string firstName;


            //Assign a value to firstname (use your name)
            firstName = "Ed";


            //Create an int name favoriteNumber and assign your fav num to it
            int favoriteNumber = 29;
            
            double crazyNumber = 7.6767 * favoriteNumber;
            

            string lastName = "Louie";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName + " " + "has favorite number of" + " " + favoriteNumber + " " +
                                    " \nwhich equates to crazy number of" + " " + crazyNumber);

            // MAKE IT DYNAMIC 

            Console.ReadKey();
        }
    }
}
