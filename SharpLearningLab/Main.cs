using System;
using System.Collections.Immutable;

class Arrays
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
    public static int Area(int a, int b)
    {
        return a * b / 2;
    }
    public static string Month(int a)
    {
        // string[] monthArr = new string[12];
        string[] monthArr = new string[12] {
            "January", "February","March", "April","May", "June", "July", "August","September", "October", "November", "December"
        };
        return monthArr[a-1];
    }
    public static double[] FindMinMax(double[] values) 
    {
        Array.Sort(values);
        return new double[] { values[0], values[values.Length - 1] };
    }
    public static int GetAbsSum(int[] arr)
    {
        int sum = 0;
        foreach (var number  in arr)
        {
            Console.WriteLine(number);
            sum += Math.Abs(number);
        }

        return sum;
    }
    public static int[] MultiplyByLength(int[] arr)
    {
        int arrLen = arr.Length;
        for (int i = 0; i<arr.Length; i++)
        {
            arr[i] = arr[i] * arrLen;
        }

        return arr;
    }
    public static int[] SortNumsAscending(int[] arr)
    {
        if (arr.Length == 0)
        {
            int[] emptyArr = new int[] { };
            return emptyArr;
        }

         
        return arr;
    }
    public static string GetFilename(string path)
    {
        string[] arr = path.Split('/');
        return arr[arr.Length - 1];
    }
}

class Strings
{
    public static string RemoveFirstLast(string str)
    {
        if (str.Length <= 2)
        {
            return str;
        }
    return str.Substring(1, str.Length - 2);
    }

    public static string Repetition(string txt, int n)
    {
        string newString = "";
        int count = n;

        if (count == 1)
        {
            return txt;
        }
        else
        {
            return txt += Repetition(txt, n - 1);
        }
    }

    public static int CountDs(string str)
    {
        return str.Count(c => c == 'D' || c == 'd');
    }
    public static string LongBurp(int b)
    {
        string output = "Bur " + new string('r', b) + "p";
        return output;
    }

}
class MainProg
{
    public static void Main()
    {
        // var a = new Arrays();
        string output = Strings.LongBurp(2);
        Console.WriteLine(output);

        // int[] arr;
        // int[] arr = new int[12];

        // int[] arr = { 2, 3 };
        // int[] arr = new int[2] { 2, 4 };

    }
}