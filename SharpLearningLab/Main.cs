using System;
using System.Collections.Immutable;

class Arrays
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value;  }
    }
    public int a, b;

    public Arrays(int num1, int num2, string NameStr)
    {
        Name = NameStr;
        a = num1;
        b = num2;
    }
    public int Sum()
    {
        return a + b;
    }
    public int Area()
    {
        return a * b / 2;
    }
    public string Month(int a)
    {
        // string[] monthArr = new string[12];
        string[] monthArr = new string[12] {
            "January", "February","March", "April","May", "June", "July", "August","September", "October", "November", "December"
        };
        return monthArr[a-1];
    }
    public double[] FindMinMax(double[] values) 
    {
        Array.Sort(values);
        return new double[] { values[0], values[values.Length - 1] };
    }
    public int GetAbsSum(int[] arr)
    {
        int sum = 0;
        foreach (var number  in arr)
        {
            Console.WriteLine(number);
            sum += Math.Abs(number);
        }

        return sum;
    }
    public int[] MultiplyByLength(int[] arr)
    {
        int arrLen = arr.Length;
        for (int i = 0; i<arr.Length; i++)
        {
            arr[i] = arr[i] * arrLen;
        }

        return arr;
    }
    public int[] SortNumsAscending(int[] arr)
    {
        if (arr.Length == 0)
        {
            int[] emptyArr = new int[] { };
            return emptyArr;
        }

         
        return arr;
    }
    public string GetFilename(string path)
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

    public static string HackerSpeak(string str)
    {
        str = str.Replace('a', '4');
        str = str.Replace('e', '3');
        str = str.Replace('i', '1');
        str = str.Replace('o', '0');
        str = str.Replace('s', '5');
        return str;
        
    }

    public static bool CheckEquality(object a, object b)
    {
        if (a == b) return true;
        else return false;
        
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
        var ArrObj = new Arrays(2, 4, "ggr");
        Console.WriteLine(ArrObj.Area());
        Console.WriteLine(ArrObj.Sum());
        
        ArrObj.Name = "Accessing property";
        Console.WriteLine(ArrObj.Name);

        // int[] arr;
        // int[] arr = new int[12];
        // int[] arr = { 2, 3 };
        // int[] arr = new int[2] { 2, 4 };
    }
}