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
         //variables
         int range = num2 - num1;//finding the range Alec helped with this
         IEnumerable<int> all = Enumerable.Range(num1, range);//enumerable allows you to use a range method
         int check = 0;//keep count of how many
         //Used to get the total number of instances
         int sw = 0; 
         int st = 0;
         int swst = 0;

        foreach(int s in all)
        {
            if(check == howmany)
            {
                Console.WriteLine();
                check = 0;
            }
            if (s % 3 == 0 && s % 5 == 0)//if divisible by 3 and 5
            {
                Console.WriteLine("Sweet'nSalty");
                swst++;
            } 
            else if ( s % 3 == 0) //divisible by 3
            {
                Console.WriteLine("Sweet");
                sw++;
            }
            else if (s % 5 == 0)//divisble by 5
            {
                Console.WriteLine("Salty");
                st++;
            }            
            else
            {
            Console.WriteLine($"{s}");//just print number
            }
            check++;                 
        }
        //results
        Console.WriteLine();
        Console.WriteLine($"The Number of Sweets is {sw}");
        Console.WriteLine($"The Number of Salty's is {st}");
        Console.WriteLine($"The Number of Sweet&Salty is {swst}");
        Console.WriteLine();
     
       
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


