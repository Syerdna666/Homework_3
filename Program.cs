// Task_1
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


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void GetCubeTable(int number){
    for (int i = 1; i <= number; i++){
        double result = Math.Pow(i, 3);
        System.Console.Write(result + " ");
    }
}
GetCubeTable(5);



int[] GetCubes (int n){
    int[] arr = new int[n];

    for (int i = 1; i <= n; i++){
        arr[i - 1] = i* i* i;
    }

    return arr;
}

foreach (int num in GetCubes(5)){
    System.Console.Write(num + " ");
}