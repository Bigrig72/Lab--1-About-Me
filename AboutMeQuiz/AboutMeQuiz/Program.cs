using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int guesses = 0;

            Console.WriteLine("Welcome to the about me guessing game!!, Lets get started! Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine($"Ok {name}, let's get started!");


            //Question One.
            try
            {
                string heightResponse = HeightQuestion();


                if (heightResponse == "Correct")
                {
                    guesses++;
                    Console.WriteLine($"That is correct, {name}");
                }
                else
                {
                    Console.WriteLine($"Sorry {name} im actually 79 inches tall, which is 6'7");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception thrown: {ex.Message}");
            }
          

            //Question 2

            try
            {

                string footballResponse = footballQuestion();

                if ( footballResponse == "correct")
                {
                    guesses++;
                    Console.WriteLine($"That is correct, {name}");

                }
                else
                {
                    Console.WriteLine($"Sorry {name} we actually won a championship each year I was there! Very proud to be part of a winning team!");
                }



            }
            catch (Exception e)
            {

                Console.WriteLine($"Exception thrown: {e.Message}");
               
            }
           

            //Question 3

            try
            {

                bool benchpress = benchPressQuestion();
              

                if (benchpress == true)
                {
                    guesses++;
                    Console.WriteLine($"That is correct, {name}");

                }
                else
                {
                    Console.WriteLine($"Sorry {name} I actaully barely made it to 40 reps, but sure did!");
                }



            }
            catch (Exception e)
            {

                Console.WriteLine($"Exception thrown: {e.Message}");

            }
            finally
            {
                Console.WriteLine($"Finished Quiz. Score: {guesses}");
            }

        }

        static string HeightQuestion()
        {
            Console.WriteLine("Im about the height of an NFL offensive tackle, can you guess in inches?");
            string heightGuess = Console.ReadLine();
            int heightConvert = Convert.ToInt32(heightGuess);

            if (heightGuess != "79")
            {
                return "Incorrect";
            }

            return "Correct";
        }

        static string footballQuestion()
        {
            Console.WriteLine("I played football at Appalachian State University, guess how many championships we won all 5 years I was there?");
            string champGuess = Console.ReadLine();
            int champConvert = Convert.ToInt32(champGuess);

            if(champConvert != 5)
            {
                return "incorrect";
            }

            return "correct";

        }

        private static bool benchPressQuestion()

        {
            Console.WriteLine("Did I bench press 225 lbs. 40 times at the pro-day when preparing for the NFL? Guess true or false");
            string benchGuess = Console.ReadLine();

            if(benchGuess == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}