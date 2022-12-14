/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
using static System.Console;
using Methods;
string[] arr1 = new string[]{"Hello","2","world",":-)"};
string[] arr2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] arr3 = new string[] { "Russia", "Denmark", "Kazan"};

mtd.printResult(arr1);
mtd.printResult(arr2);
mtd.printResult(arr3);