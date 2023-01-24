/*
Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что 
третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int GetNumber(int a_count)
{
    int result = a_count/100-(a_count/1000)*10;
    return result;
}

int number = GetNumber(1);

if (number == 0) 
{
    Console.WriteLine("третьей цифры нет");
}
else {
    Console.WriteLine(number);
}