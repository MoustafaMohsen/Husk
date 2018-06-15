using System;

namespace Husk
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter your name and hello massage
            Console.WriteLine("enter you name to proceed...");
            string Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello {0}, let's play a game .. Guess what number I'm thinking of from 1-10 ?!",Name);
            Console.ResetColor();



            //============ operation
            while (true)
            {
                //random number generator
                Random class_correct = new Random();
                int correct = class_correct.Next(1, 10);


                //----loop through till input is right

                //guess inputs
                int guess = intputToint();
                while (guess != correct)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} is incorrect try again !", guess);
                    Console.ResetColor();
                    guess = intputToint();
                }

                //if it's right then write congrats in yellow
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (guess == correct)
                { Console.WriteLine("Congrates you are right sir, hats off ... _|_ head"); }
                Console.ResetColor();

                //ask if user wants to continue 
                Console.WriteLine("do you want to continue [Y] ?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y") { continue; }
                else  { return; }



            }


            //method to take input and make it a number
            int intputToint()
            {
                string x = Console.ReadLine();
                int y;
                if (!int.TryParse(x, out y))
                { 
                    while (!int.TryParse(x, out y))
                    {
                        Console.WriteLine("Not a Number");
                        x = Console.ReadLine();
                    }//while
                }//if
                y = Int32.Parse(x);
                return y;
            }
        }//main method
    }//Class
}//namespace
