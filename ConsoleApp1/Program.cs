using ConsoleApp1;
using System.ComponentModel.DataAnnotations;

var rnd = new Random().Next(10);
var arr = DigitOperation.GetRndArray(rnd);
var shiftedArr = DigitOperation.ShiftArray(arr);
Console.WriteLine($"{arr} {rnd}");
Console.WriteLine($"{shiftedArr}");