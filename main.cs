using System;

class Program {
  public static void Main (string[] args) {

    // User Inputs

    Console.WriteLine("Enter the wind speed in miles per hour: \n");

    // Define the Variables
    double windSpeed = Convert.ToDouble(Console.ReadLine());
    
    // Conditional Statement
    if (windSpeed >= 157)
    {
      Console.WriteLine("\nCategory Five Hurricane");
    }
    else if (windSpeed >= 130)
    {
      Console.WriteLine("\nCategory Four Hurricane");
    }
    else if (windSpeed >= 111)
    {
      Console.WriteLine("\nCategory Three Hurricane");
    }
    else if (windSpeed >= 96)
    {
      Console.WriteLine("\nCategory Two Hurricane");
    }
    else if (windSpeed >= 74)
    {
      Console.WriteLine("\nCategory One Hurricane");
    }
    else
      {
      Console.WriteLine("\nNot a Hurricane");
    }
    
  }
}