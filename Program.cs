﻿// Task_1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


bool IsPalindrome(int number)
{
    int reversedNumber = 0;
    int j = Math.Abs(number);
    while (j > 0)
    {
        reversedNumber = reversedNumber * 10 + j % 10;
        j = j / 10;
    }
     return (Math.Abs(number) == reversedNumber);
}

System.Console.WriteLine(IsPalindrome(13821));


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double Get3DRange (int x1, int y1, int z1, int x2, int y2, int z2) {

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
return Math.Round(result, 2);
}

System.Console.WriteLine(Get3DRange(7, -5 , 0, 1, -1, 9));