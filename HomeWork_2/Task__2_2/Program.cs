/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine());
int count = num.ToString().Length;
int k = 1;
int result = 0;

if (count < 3)
    Console.WriteLine($"Число {num} - третьей цифры нет.");
else {
    while(count > 3)
    {
        k = k * 10;
        count = count - 1;
    }
    result = (num / k) % 10;
    Console.WriteLine($"{num}: {result}");
}

