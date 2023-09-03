﻿using System;
using System.Collections.Immutable;

class Practice
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
}

class MainProg
{
    public static void Main()
    {
        var a = new Practice();
        var input  = Console.ReadLine();
        string[] arrInput = input.Split(' ');
        int[] intArr = arrInput.Select(int.Parse).ToArray();
        
        Console.WriteLine($"Sum: {Practice.GetAbsSum(intArr)}");
        
        // Console.WriteLine(Practice.Month(int.Parse(Console.ReadLine())));
        // Console.WriteLine(a.Sum(1, 2));
        // Console.WriteLine(Practice.Area(1, 2));
        
        // int[] arr;
        // int[] arr = new int[12];

        // int[] arr = { 2, 3 };
        // int[] arr = new int[2] { 2, 4 };

    }
}