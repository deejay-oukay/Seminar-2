int number = 0;
string testNumber;
bool correct = false;
while(!correct)
    {
        Console.Write("Введите число: ");
        testNumber = Console.ReadLine().Trim();
        if (!int.TryParse(testNumber,out number))
            Console.Write("Вы ввели не число. ");
        else
            {
                correct = true;
                if (testNumber.Length < 3)
                    Console.WriteLine("Третьей цифры нет");
                else
                    Console.WriteLine($"Третеья цифра: {testNumber[2]}");
            }
    }


