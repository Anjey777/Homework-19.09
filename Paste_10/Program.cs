/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetRandomNumber(int leftRange, int rightRange) // [100-1000)
{
    Random rnd = new Random();
    int result = rnd.Next(leftRange, rightRange); // [leftRange,rightRange)
    return result;
}

int DeleteSecondDigit(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;

    return firstDigit*10 + thirdDigit;
}

int number = GetRandomNumber(100,1000);
Console.WriteLine(number);

int twoDigits = DeleteSecondDigit(number);
Console.WriteLine(twoDigits);