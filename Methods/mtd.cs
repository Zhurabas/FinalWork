﻿using System;
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
public static string[] noMore3SymArr(string[]arr)
{
    int resultLength = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<4)resultLength++;
    }

    string[] result=new string[resultLength];
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
            if (arr[i].Length < 4)
            {
                result[counter++] = arr[i]; 
            }
            else continue;
    }
    return result;
}
}
