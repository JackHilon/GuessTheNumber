using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guess The Number
            // https://open.kattis.com/problems/guess 
            // ...... I get error: Time Limit Exceeded ......
            // ..............................................

            // int heart = 50;
            string result;

            int brainGuess;
            for (int i = 0; i < 10; i++)
            {

                // brainGuess = EnterNumber();
                brainGuess = int.Parse(Console.ReadLine());

                result = YourGuess(50, brainGuess);

                Console.WriteLine(result);

                if (result == "correct")
                    break;


            }
        }
        private static string YourGuess(int myHeart, int yourBrain)
        {
            if (yourBrain > myHeart)
                return "lower";
            else if (yourBrain < myHeart)
                return "higher";
            else
                return "correct";
        }
            
        private static int EnterNumber()
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a < 1 || a > 1000)
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterNumber();
            }
            return a;
        }
    }
}
