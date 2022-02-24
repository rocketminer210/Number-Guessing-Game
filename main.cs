using System;

class Program {
  public static void Main (string[] args) {
    var Rand = new Random();
    int guessTracker = 0;
    int answer =  Rand.Next(101);
    
    
    while (guessTracker < 7)
    {
      int guessesRemaining = 7 - guessTracker;
      Console.WriteLine(Convert.ToString(guessesRemaining) + " guesses remaining.");
      Console.WriteLine("Insert Guess");
      int guess = Convert.ToInt32(Console.ReadLine());
      if (guess < 101 && guess > -1)
      {
        if (guess < answer)
        {
          Console.WriteLine("Guess is lower than answer");
          guessTracker++;
          
        }
        else if (guess > answer)
        {
          Console.WriteLine("Guess is above answer");
          guessTracker++;
          
        }
        else
        {
          int success = guessTracker + 1;
          Console.WriteLine("Success in " + Convert.ToString(success)+ " Tries.");
          guessTracker = 7;
          
        }
      }
      else
      {
        Console.WriteLine("Invalid Guess. Between 0 and 100");
      }
    
      
      
    }
    Console.WriteLine("game complete");
    Console.Write(Convert.ToString(answer));
  }
}