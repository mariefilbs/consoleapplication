using System;

namespace helloworld
{
    class Program
    {   
        static void Main(string[] args)
        {
            //declaring my variable
            int input, x;
            //asking for user input in the console
            Console.WriteLine("Enter the Number ");
            //converting the input from a string to a number and storing it as the input
            input = int.Parse(Console.ReadLine());
            
            /*this is where I am really hitting a wall.
            I am able to enter in a number, but then the program stops running.*/
            
            Console.WriteLine("The Prime Factors are : ");
            
            //here is my logic for the prime factors.
            for (x = 1; x <= input; x++)
            {
                if (input % x == 0)
                {
                    /*from researching, I gathered that I need to translate this
                    into a List to be comma seperated, but I couldn't quite figure it out in time.*/
                    Console.WriteLine(x);
                }
            }

            //Reading the expected output?
            Console.ReadLine();
 
        }
    }
  }
 

    


    


