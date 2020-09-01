using System;


namespace SwitchStatement
{
    class Program
    {
        static void Main()
        {

            bool condition = true;

            while (condition)
            {
                Console.WriteLine("Which beer should we drink? Pick a number between 1 and 5");
                int beer = Convert.ToInt32(Console.ReadLine());

                while (condition)
                {
                    switch (beer)
                    {
                        case 1:
                            Console.WriteLine("Sweet As Pale Ale");
                            condition = false;
                            break;
                        case 2:
                            Console.WriteLine("Ecliptic IPA");
                            condition = false;
                            break;
                        case 3:
                            Console.WriteLine("Little Beast Wolf Pack Hoppy Saison");
                            condition = false;
                            break;
                        case 4:
                            Console.WriteLine("Little Beast IPA");
                            condition = false;
                            break;
                        case 5:
                            Console.WriteLine("Little Beast Pina Colada");
                            condition = false;
                            break;
                        default:
                            Console.WriteLine("You didn't pick a valid number :-(  \nTry again!");
                            Console.WriteLine("Which beer should we drink? Pick a number between 1 and 5");
                            beer = Convert.ToInt32(Console.ReadLine());
                            break;
                    }

                }

                //if (beer > 5 || beer < 1)
                //{
                //    Console.WriteLine("You didn't pick a valid number :-( \nGoodbye!");
                //    Console.ReadLine();
                //    Environment.Exit(0);
                //}



                Console.WriteLine("Are you happy with your choice? y/n");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Enjoy your beer!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(":-( \nLet's try again. \nPick a number between 1 and 5");
                    condition = true;
                    Console.ReadLine();
                }
            }
        }
    }
}
