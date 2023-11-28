// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace showGrade{

class Program{

    public static string grade(int x)
    {
        if (x >= 90){return "A" ;}
        if (x<90 && x>=80){return "B";}
        if (x<80 && x>=70){return "c";}
        if (x<70 && x>=60){return "D";}
        else{ return "F";}
    }

    public static void Main(string[] args)
    {
       List<int> scores = new List<int>
       {
        87, 92, 100, 52, 72, 84, 81, 74, 90
       } ;

       for(int i = 0; i<scores.Count;i++)
       {
        string gradeIs = grade(scores[i]);
        Console.WriteLine(gradeIs);
       }
    }
}
}

