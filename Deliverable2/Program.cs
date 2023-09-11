using System;

public class Program
{
    public static void Main()
    {
            int round = 1;
            int score = 0;

        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
        Console.WriteLine("Hello " +  name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
            string ca = Console.ReadLine();
            string calow = ca.ToLower();
        //No reponse
        if (calow == "no")
        {
            Console.WriteLine(name + " you are a coward! Goodbye!");
        }
        
        //Yes reponse
        else if (calow == "yes")
        {
            while (round <=5)
            {
                Console.WriteLine("Heads or Tails?");
                    string flip = Console.ReadLine();
                    string flipLow = flip.ToLower();
                    Random rnd = new Random();
                    int coin = rnd.Next(0, 2);
                    string coinString = "heads";
                    
                if (coin == 0)
                {
                    coinString = "tails";
                }
                else if (coin == 1)
                {
                    coinString = "heads";
                }

                if (flipLow == coinString)
                {
                    Console.WriteLine("Correct!");
                    round++;
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                    round++;
                }
            }

            Console.WriteLine("Thank you " + name + ". You got a score of " + score + "!");
        }

        //Invalid response
        else
        {
            Console.WriteLine("Response cannot be interupted. Please try again");
        }




















    }
}