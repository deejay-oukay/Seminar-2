int Input(string message)
    {
        int number = -1;
        while(number == -1)
            {
                Console.Write(message);
                string testNumber = Console.ReadLine().Trim();
                if (!int.TryParse(testNumber,out number))
                    Console.Write("Вы ввели не число или некорректное число. ");
                //Выше TryPatse может привести строку к нулю. Хотя введена могла быть любая другая строка. А нолик нам нужен, как один из допустимых вариантов
                if ((number == 0) && (testNumber != "0"))
                    number = -1;
            }
        return number;
    }


switch (Input("Введите число от 0 до 5: "))
{
    case 0:
        Console.WriteLine("Ноль");
        break;
    case 1:
        Console.WriteLine("Один");
        break;
    case 2:
        Console.WriteLine("Два");
        break;
    case 3:
        Console.WriteLine("Три");
        break;
    case 4:
        Console.WriteLine("Четыре");
        break;
    case 5:
        Console.WriteLine("Пять");
        break;
    default:
        Console.WriteLine("Другое число");
        break;
}