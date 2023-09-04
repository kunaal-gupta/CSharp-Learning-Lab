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

class DataStructures
{
    public static string NSidedShape(int n)
    {
        Dictionary<int, string> dict = new Dictionary<int, string>
        {
            { 1, "circle" },
            { 2, "semi-circle" },
            { 3, "triangle" },
            { 4, "square" },
            { 5, "pentagon" },
            { 6, "hexagon" },
            { 7, "heptagon" },
            { 8, "octagon" },
            { 9, "nonagon" },
            { 10, "decagon" }
        };
        if (dict.ContainsKey(n) == true)
        {
            return dict[n];
        }

        return "none";
    }

    public static string ount_all(string txt)
    {
        int LETTERS = 0;
        int DIGITS = 0;
        
        foreach (var i in txt)
        {
            if (char.IsDigit(i)) DIGITS += 1;
            else if (char.IsLetter(i)) LETTERS += 1;
        }

        string result = $"{{ LETTERS = {LETTERS}, DIGITS = {DIGITS} }}";

        return result;
    }
}
class MainProg
{
    public static void Main()
    {
        // var a = new Arrays();
        // string output = Strings.LongBurp(2);
        Console.WriteLine(DataStructures.ount_all("Hello World"));
        // Console.WriteLine(output);

        // int[] arr;
        // int[] arr = new int[12];

        // int[] arr = { 2, 3 };
        // int[] arr = new int[2] { 2, 4 };

    }
}