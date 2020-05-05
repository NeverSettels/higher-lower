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
      HighLow(RandNumb+1, max);
    }
    else{
       Console.WriteLine("Enter something valid dummy");
       HighLow(min,max);
    };    
  }

  public static void LowerHigher(int myNumber)
  {
    
    Console.WriteLine("Guess jabronie.");
    int response = int.Parse(Console.ReadLine());
    if (response < myNumber)
    {
      Console.WriteLine("Higher");
      LowerHigher(myNumber);
    }
    if (response > myNumber)
    {
      Console.WriteLine("Lower");
      LowerHigher(myNumber);
    }
    if (response == myNumber)
    {
      Console.WriteLine("yeah yeah, don't let it go to your head.");
      
    }
  }
  public static void Main()
{
  Console.WriteLine("Let's play a game of Higher/Lower");
  Console.WriteLine("Who should go first? [YOU or ME]");
  string gameType = Console.ReadLine().ToLower();
  if(gameType == "you")
  {
     Random rand = new Random();
    int myNumber = rand.Next(1, 101);
    LowerHigher(myNumber);
  }
 else if (gameType == "me")
  {
  HighLow(0,101);
  }
  else
  { 
    Console.WriteLine("wise guy huh? Fine I'll go then.");
     Random rand = new Random();
    int myNumber = rand.Next(1, 101);
    LowerHigher(myNumber);
    }
  }
}

