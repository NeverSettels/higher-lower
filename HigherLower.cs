using System;


public class Guess
{
  public static void HighLow(int min, int max)
  {
    Random rand = new Random();
    int RandNumb = rand.Next(min,max);
    Console.WriteLine($"Is this your number {RandNumb}? [HIGHER/LOWER/CORRECT]");
    string response = (Console.ReadLine().ToLower());
    if(response == "correct")
    {
      Console.WriteLine("Got it you dumb dumb");
    }
    else if(response == "lower")
    {
      HighLow(min, RandNumb);
    }
    else if(response == "higher")
    {
      HighLow(RandNumb, max);
    }
    else{
       Console.WriteLine("Enter something valid dummy");
       HighLow(min,max);
    };    
  }
  public static void Main()
{
  Console.WriteLine("Let's play a game of Higher/Lower");
  HighLow(0,101);
}
}

