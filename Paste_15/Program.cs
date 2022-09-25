/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введи цифру, обозначающую день недели: ");
int daynumber = Convert.ToInt32 (Console.ReadLine());
if ((daynumber ==6) || (daynumber ==7))
{
Console.WriteLine(("(Это выходной день) - ДА"));
}
else if ((daynumber<1) || (daynumber>7))
{
Console.WriteLine("Вы ошиблись, в неделе 7 дней");
}
else Console.WriteLine("(Этот день будний) - НЕТ");