using System;
using static System.Console;
namespace Methods;
public class mtd
{
public static void printStringArr(string[]arr)
{
    Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr[i].Length; j++)
            Write($"{arr[i][j]}");
       if(i!=arr.Length-1) Write(", ");
    }
    Write("]");
}
}
