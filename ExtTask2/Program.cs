int Generate(string message)
    {
        int number = new Random().Next(10,31);
        Console.WriteLine(message+number);
        return number;
    }

int first = Generate("Первое число: ");
int second = Generate("Второе число: ");

if (first > second)
    Console.WriteLine($"Разность между {first} и {second} равна "+(first-second));
else if (first < second)
    Console.WriteLine($"Сумма {first} и {second} равна "+(first+second));
else
    Console.WriteLine($"Числа {first} и {second} равны");
