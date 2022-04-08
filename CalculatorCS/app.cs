using System;

namespace HelloWorld {
  class MainClass {
    // Main Method
    public static void Main (string[] args) {
      string[] operations = {"Add", "Subtract", "Multiply", "Divide", "Cube", "Square Root"};
      //Could also use Convert.ToDouble(Console.ReadLine()); in place of double.Parse.
      Console.WriteLine("What would you like your first number to be?");
      double x = double.Parse(Console.ReadLine());
      Console.WriteLine("What would you like your second number to be? (If Cubing or Square Rooting, second number does not matter)");
      double y = double.Parse(Console.ReadLine());
      //Grabs the operator from the user
      Console.WriteLine("What would you like to do? " + string.Join(", ", operations));
      string operate = Console.ReadLine();
      //NewMath method is given an operator, and two numbers and does the math for you
      NewMath(operate, x, y);
    }
    // NewMath method
    public static void NewMath(string operate, double x, double y) {
      if(operate == "Add") {
        Console.WriteLine("Your equation is " + x + " plus " + y + " equals " + (x + y));
      } else if(operate == "Subtract") {
        Console.WriteLine("Your equation is " + x + " subtract " + y + " equals " + (x - y));
      } else if(operate == "Multiply") {
        Console.WriteLine("Your equation is " + x + " multiplied by " + y + " equals " + (x * y));
      } else if(operate == "Divide") {
        Console.WriteLine("Your equation is " + x + " divided by " + y + " equals " + (x/y));
      } else if(operate == "Cube") {
        Console.WriteLine("Your cubed number is " + Cube(x));
      } else if(operate == "Square Root") {
        Console.WriteLine("The square root of " + x + " is " + SquareRoot(x));
      } else {
        Console.WriteLine("That is not a valid operator.");
      }
    }
    // Cube Operation Method
    public static double Cube(double num) {
      double result = num * num * num;
      return result;
    }
    //Square Root Operation Method
    public static double SquareRoot(double num) {
      double result = Math.Sqrt(num);
      //Checks and makes sure the Sqrt() method is returning a number
      if(result == 0) {
        return 0;
      } else {
        return result;
      }
    }
  }
}