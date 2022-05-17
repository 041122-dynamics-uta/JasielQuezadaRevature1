using System;
using System.Linq;
using System.Collections.Generic;

namespace dotnetconsole_SweetnSalty
{
    class Program
    {
        static void Main(string[] args)
     {
         //get numbers from users
         Console.WriteLine("Please enter the starting number");
         int num1 = Convert.ToInt32(Console.ReadLine()); //convert string to number
         Console.WriteLine("Please enter ending number");
         int num2 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("How many numbers per line would you like?");
         int howmany = Convert.ToInt32(Console.ReadLine());
        
            IEnumerable<int> numbers = Enumerable.Range(num1, range);
            
            for (int i = 1; i <= 10; i++)
            {
            
            if ( i % 3 == 0) //divisible by 3
            {
            Console.WriteLine("Sweet");
            }
            else if (i % 5 == 0)//divisble by 5
            {
            Console.WriteLine("Salty");
            }  
            else if (i % 3 == 0 && i % 5 == 0)//if divisible by 3 and 5
            {
            Console.WriteLine("Sweet'nSalty");
            }            
            else
            {
            Console.WriteLine(i);//just print number
            }                 
        }
     
       
        }//end of static void
    }//end of class
     
}//end of namespace
// Get the start and stop numbers (the range) from the user.
// Get the quantity of numbers you will print per line from the user.
// Print the numbers in groups of what the user says per line with one space separating each number.
// If the number is a multiple of three, print “Sweet” (instead of the number) to the console.    
// If the number is a multiple of five, print “Salty” (instead of the number) to the console.    
// For numbers which are multiples of both three and five,
// print “Sweet’nSalty” to the console (instead of the number).
// After the numbers have all been printed to the console, print to the console on 3 separate lines:
// how many "Sweet",
// how many "Salty", and
// how many "Sweet’nSalty"
// 'Sweet', 'Salty', and 'Sweet'nSalty' are three separate groups, 
//so "Sweet’nSalty" does not increment "Sweet" or "Salty" (and vice versa).
// Include verbose commentary in the source code to tell me what each few lines are doing.






// {
//             int[] allNumbers = Enumerable.Range(1, 20).ToArray();
//             GetNumbers(ref allNumbers, new int[] { 16, 17 });
//             }
//             public class Range
//             {
//             IEnumerable<int> range = Enumerable.Range(1, 20);
//              int Start {get;set;}
//              int End {get;set;}
//             }


// void findMultiples(int n){
//   for(int i = 0; i <= n; i++)
//     if(i % 3 == 0 && i % 5 == 0)
//       cout << i << endl;

//   return 0;
//   public readonly struct Range
//     {
//         public Range(System.Index start, System.Index end);
//         public static Range All { get; }
//     }


