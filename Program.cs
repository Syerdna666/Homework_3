// Task_1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


bool IsPalindrome(int number)
{
    int reversedNumber = 0;
    int j = Math.Abs(number);
    while(j > 0) {
        reversedNumber = reversedNumber * 10 + j % 10;
        j = j / 10;
    }
    if (Math.Abs(number) == reversedNumber){
        return true;
    }
    else return false;
}

System.Console.WriteLine(IsPalindrome(12821));
    



