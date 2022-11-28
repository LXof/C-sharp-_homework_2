/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите цифру дня недели: ");
int num = int.Parse(Console.ReadLine());


switch (num)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5: 
            Console.Write($"{num}: Будний день");
            break;
    case 6:
    case 7:
            Console.Write($"{num}: ВЫХОДНОЙ!");
            break;
    default: 
            Console.WriteLine("В неделе 7 дней!");
            break;
}
