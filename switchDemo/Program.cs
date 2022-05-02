using System;

namespace switchDemo
{
    class Program
    {
        static void Main(string[] args)
        {

   //int grade = 5;
   Console.WriteLine("Enter a letter grade: ");
   string input = Console.ReadLine();


   switch(input) {
      case "A" :
   Console.WriteLine("Excellent!");
         break;
      case "B" :
   Console.WriteLine("Good Job!");
         break;
      case "C" :
   Console.WriteLine("Well done");
         break;
      case "D" :
   Console.WriteLine("You passed");
         break;
      case "F" :
   Console.WriteLine("Better try again");
         break;
      default:
   Console.WriteLine("Please enter only valid grades");
        break;
    }
}
}
}
