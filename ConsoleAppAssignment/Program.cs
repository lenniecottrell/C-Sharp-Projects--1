using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //p. 197 one dimentional array of strings  - Part 1
            string[] bobsBurgersArr = { "Bob ", "Linda ", "Tina ", "Louise ", "Gene " };

            //print the array
            for (int i = 0; i < bobsBurgersArr.Length; i++)
            {
                Console.WriteLine("Members of the Belcher family: " + bobsBurgersArr[i]);
            }

            //get input from the user
            Console.WriteLine("Please enter the last name of the family above: ");
            string belcher = Console.ReadLine();

            //add the users text to the text in the array
            for (int i = 0; i < bobsBurgersArr.Length; i++)
            {
                Console.WriteLine(bobsBurgersArr[i] + belcher);
            }
            Console.ReadLine();



            //P. 198 - Part 2
            for (int i = 0; i < 1000; i++) //to make this an infinite loop, I wrote int (i = 1; i > 0; i++)
            {
                if (i < 999)
                {
                    Console.WriteLine("OH NOE INFINITE LOOP!!!!!");
                }
                else
                {
                    Console.WriteLine("JK loop is done lol");

                }
            }
            Console.ReadLine();



            //P. 199 - Part 3
            //a loop that resolves by using the < operator
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
            }

            //a loop that resolves by using the <= operator 
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz!");
                }
                else if (i % 5 == 0 )
                {
                    Console.WriteLine("buzz");
                }
            }
            Console.ReadLine();



            //p. 200: A list of unique strings - Part 4
            List<string> games = new List<string>() { "The Witcher", "Breath of the Wild", "Doom", "Overwatch", "Super Mario Odyssey", "PilotWings 64" };

            //Input search text
            Console.WriteLine("Please enter a video game title to search for: ");
            string searchTerm = Console.ReadLine();
            bool existsInLoop = false;

            //A loop that iterates through the list and displays the index of the list that contains matching text on screen
            foreach (string game in games)
            {
                if (game == searchTerm)
                {
                    Console.WriteLine("That game has been found at index number {0}", games.IndexOf(game));
                    Console.ReadLine();
                    Console.WriteLine("Thank you for searching!");
                    Console.ReadLine();
                    existsInLoop = true;
                    break; //Exits the loop once a match is found
                }
            }
            if (!existsInLoop) //Tells the user that their text was not found
            {
                Console.WriteLine("Sorry, that game does not exist in the database");
            }



            //P. 201 - Part 5
            List<string> dogNames = new List<string>() { "sparky", "spot", "patches", "Henry", "spot", "ella", "spot", "fido", "jerry" };
            List<int> indeces = new List<int>();

            Console.WriteLine("Please enter a dog name: ");
            string pup = Console.ReadLine();

            for (int i = 0; i < dogNames.Count; i++)
            {
                if (dogNames[i] == pup)
                {
                    indeces.Add(i);
                }
                else if (!dogNames.Contains(pup))
                {
                    Console.WriteLine("Sorry, " + pup + " was not found");
                    break;
                }
            }
            foreach (int index in indeces)
            {
                Console.WriteLine(pup + " was found at index: " + index);
            }
            Console.ReadLine();


            //P. 202 - Part 6
            List<string> gamesList = new List<string>() { "The Witcher", "Overwatch", "Breath of the Wild", "Doom", "Overwatch", "Super Mario Odyssey", "Donkey Kong Country", "Doom", "PilotWings 64" };
            List<string> checkerList = new List<string>(); //I know this is not memory-efficient, but it gets the job done!
            foreach (string game in gamesList)
            {
                Console.WriteLine(game); //displays each strign in the list

                //check to see if the game exists in the checker list or not
                if (!checkerList.Contains(game)) 
                {
                    checkerList.Add(game);
                }
                else
                {
                    Console.WriteLine("\t******The above game already exists in the list*******");
                }
            }
            Console.ReadLine();












        }
    }
}
