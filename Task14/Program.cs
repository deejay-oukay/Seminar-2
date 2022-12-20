int number = 0;
while(number == 0)  //попутно избегаем деления на 0
    {
        Console.Write("Введите число: ");
        string testNumber = Console.ReadLine().Trim();
        if (!int.TryParse(testNumber,out number))
            Console.Write("Вы ввели не число или некорректное число. ");
    }

if ((number % 7 == 0) && (number % 23 == 0))
    Console.WriteLine($"Да. {number} одновременно кратно 7 и 23");
else
    Console.WriteLine($"Нет. {number} НЕ кратно 7 и/или 23");


