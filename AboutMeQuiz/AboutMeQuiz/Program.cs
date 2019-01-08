using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // counter created in the main to track nuber of guesses. 
            int guesses = 0;

            Console.WriteLine("Welcome to the about me guessing game!!, Lets get started! Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine($"Ok {name}, let's get started!");


            //Question One. Running my conditions here and calling methods, which you will find below. 
            //First Question is the height question
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
          

            //Question 2--Championships question

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
            //Boolean method called to return true or false 
            // still tracking guesses
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
           

            //Question 4--Cities guess

            try
            {

                uint citiesResponse = cityInfoGuess();

                if (citiesResponse == 5)
                {
                    guesses++;
                    Console.WriteLine($"That is correct, {name}");

                }
                else
                {
                    Console.WriteLine($"Sorry {name} I actually lived in 4 cities, Malone NY, Selinsgrove PA, Atlanta GA, Boone NC was where I went to school and Washington DC is my home");
                }



            }
            catch (Exception e)
            {

                Console.WriteLine($"Exception thrown: {e.Message}");

            }
            // Question 5
            try
            {

                string twinsResponse = TwinsGuess();

                if (twinsResponse == "correct")
                {
                    guesses++;
                    Console.WriteLine($"That is correct, {name}");

                }
                else
                {
                    Console.WriteLine($"Sorry {name} Their names are Colton and Brayden!");
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

        //Beginning of my methods for each question..Find below

        //Question 1    

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

        //Question 2

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

        //Question 3

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

        //Question 4

        static uint cityInfoGuess()
        {
            Console.WriteLine("Guess the number of cities I have lived in?");
            string guesses = Console.ReadLine();
            int cityGuess = Convert.ToUInt16(guesses);

            if (cityGuess != 5)
            {
                return 1;
            }
            else
            {
                return 5;
            }
        }

        // Question 5 
        static string TwinsGuess()
        {
            Console.WriteLine("Guess the two names of my twin boys?");

            string[] nameArray = { "Colton", "Danny", "Brayden", "Stephen" };

            foreach (string name in nameArray)
            {
                System.Console.WriteLine($"Names: {name}");
            }

            string twinGuess = Console.ReadLine();

            string twinGuess2 = Console.ReadLine();


            if ((twinGuess != nameArray[0] && twinGuess != nameArray[2]) && (twinGuess2 != nameArray[0] && twinGuess2 != nameArray[2]))
            {
                return "incorrect";
            }
            return "correct";
           








        }
    }
}