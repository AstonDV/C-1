Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
if (x == 1)
{
    Console.Write("Понедельник");
}

if (x == 2)
{
    Console.Write("Вторник");
}

if (x == 3)
{
    Console.Write("Среда");
}

if (x == 4)
{
    Console.Write("Четверг");
}

if (x == 5)
{
    Console.Write("Пятница");
}

if (x == 6)
{
    Console.Write("Суббота");
}

if (x == 7)
{
    Console.Write("Воскресенье");
}

else if (x < 1 || x > 7)
{
    Console.Write("Такого дня недели не бывает");
}