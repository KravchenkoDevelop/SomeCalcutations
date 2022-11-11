using ConsoleApp1;
using System.ComponentModel.DataAnnotations;

var rnd = new Random().Next(5,15);
var arr = DigitOperation.GetRndArray(rnd);
var shiftedArr = DigitOperation.ShiftArray(arr);
Console.WriteLine("generated array with length "+rnd);
OutputOperation.PrintArray(arr);
Console.WriteLine();
OutputOperation.PrintArray(shiftedArr);
Console.WriteLine();
var maxElem = Search.BinarySearch(shiftedArr);
Console.WriteLine(maxElem);

Console.ReadKey();