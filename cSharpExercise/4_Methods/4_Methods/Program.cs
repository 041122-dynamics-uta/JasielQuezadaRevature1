using System;

namespace _4_MethodsChallenge
// In this challenge we will expand our understanding of methods.
// 1. Create a GetName() method that asks the user for their name and returns the name.
// 2. Create a GreetFriend() Method that takes a string 'name' and returns "Hello, <name>. You are my friend."

// Calculator - Create a calculator to do some Mathmatical operations on 2 numbers that you get from the user.
// 1. Create a GetNumber() method to get a number from the user. 
//     - It will return a double.
//     - Validate that the user input is a double.
//     - If the userInput is not valid, reprompt until the user inputs the correct data type.
// 2. Create a GetAction() method that gets the action to take on the numbers inputted from the user. 1)add, 2)subtract, 3)multiply, or 4)divide. 
//     - It will return an int signifying the choice made.
//     - Keep reprompting until the user enters the correct input.
// 2. Create a method, DoAction() that takes 2 doubles and an int as parameters. 
//     - This method will do the calculation indicated, while avoiding Arithmetic Exceptions.
//     - Print the result to the console.
//     - It will also return a double as the result of the calculation. 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/
        }

        public static string GetName()
        {
            //throw new NotImplementedException("GetName() is not implemented yet0");
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            return name;
    
        }

        public static string GreetFriend(string name)
        {
             //throw new NotImplementedException("GreetFriend() is not implemented yet");
             return "Hello, " + name + ". " + "You are my friend.";

        }

        public static double GetNumber()
        {
            //throw new NotImplementedException("GetNumber() is not implemented yet");
            Double num = Convert.ToDouble(Console.ReadLine());
            return num;

        }

        public static int GetAction()
        {
            //throw new NotImplementedException("GetAction() is not implemented yet");
            int action = Convert.ToInt32(Console.ReadLine());
            return action;
        }

        public static double DoAction(double x, double y, int action)
        {
             //throw new NotImplementedException("DoAction() is not implemented yet");
            switch(action)
            {
              case 1:
                return x + y;
              case 2:
                return Math.Abs(x - y);
              case 3:
                return x * y;
              case 4:
                return x / y;
              default:
                throw new FormatException("Wrong Format");  
            }
        }
    }
}//Eo
