using System;
using System.Runtime.CompilerServices;

public class Summator
{
    public static int Calc(int[] arr, string op = "sum")
    {
        if(op == "sum")
        {
            return Sum(arr);
        } else {
            return Multiply(arr);
        }
    }
    private static int Sum(int[] arr)
    {
        int sum = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    private static int Multiply(int[] arr)
    {
        int multiplyResult = arr[0];
        for( int i = 1; i< arr.Length; i++)
        {
            multiplyResult *= arr[i];
        }
        return multiplyResult;
    }
    
    static void Main()
    {
        Console.WriteLine(Calc(new int[] { 10, 20, 30 }, "multiply"));
    }
}