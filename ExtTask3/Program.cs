int Generate(string message)
    {
        int number = new Random().Next(-10,10);
        Console.WriteLine(message+number);
        return number;
    }

int first = Generate("Первое число: ");
int second = Generate("Второе число: ");

if (first % 2 == 0 && second % 2 == 0)
    Console.WriteLine($"Частное от двух чётных чисел {first} и {second} равно "+Convert.ToDouble(first)/Convert.ToDouble(second));
else if (first % 2 != 0 && second % 2 != 0)
    Console.WriteLine($"Сумма нечётных чисел {first} и {second} равна "+(first+second));
else if ((first % 2 == 0 && second % 2 != 0) || (first % 2 != 0 && second % 2 == 0)
)
    Console.WriteLine($"Одно из чисел {first} и {second} чётное, а другое - нет. Их произведение равно {first*second}");
