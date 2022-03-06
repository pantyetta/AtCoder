using System;

namespace ABC049C
{
    class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
 
            
            //erがあるからdreamer より先に eraserとか erから始まるの
            
            input = input.Replace("eraser", "");
            input = input.Replace("erase", "");
            input = input.Replace("dreamer", "");
            input = input.Replace("dream", "");
 
            Console.WriteLine(input.Length == 0 ? "YES" : "NO");
        }
    }
}

/*
var str = "";
var oldflag = false;

foreach (var s in Console.ReadLine())
{
    str += s;
    var flag = false;
    switch (str)
    {
        case "dream":
        case "dreamer":
        case "erase":
        case "eraser":
            flag = true;
            break;
        default:
            flag = false;
            break;
    }
    
    if (flag != oldflag && oldflag)  str = s.ToString();
    oldflag = flag;
}

Console.WriteLine(oldflag ? "YES" : "NO");
*/