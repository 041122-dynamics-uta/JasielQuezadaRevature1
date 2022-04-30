using System;

namespace migratoryBirds;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {   
        arr.Sort();
        int freq = arr[0];//these are variable instanciations
        int mostFreqSight = 1;
        int count = 0;


        for(int b = 0; b < arr.Count; b += count)//base for loop
        {   
            count = 0;
            for(int a = 0; a < arr.Count; a++)//nested for loop
            {
                if(arr[b] == arr[a])  //arr[b]=0 arr[a]=0 [1=1=true/increment]
                {
                    count++;
                }
                if(mostFreqSight < count)
                {
                    freq = arr[b];
                    mostFreqSight++;
                }  
            }
        }//EoBL
        return freq;
    }//EoP

}//EoC

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}