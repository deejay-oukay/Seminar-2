int number = 0;
string testNumber;
bool correct = false;
while(!correct)
    {
        Console.Write("Введите число от 1 до 7: ");
        testNumber = Console.ReadLine().Trim();
        if (!int.TryParse(testNumber,out number))
            Console.Write("Вы ввели не число. ");
        else if ((number < 1) || (number > 7))
            Console.Write("Вы ввели некорректное число. ");
        else
            {
                correct = true;
                if (number > 5)
                    Console.WriteLine("Выходной день");
                else
                    Console.WriteLine("Рабочий день");
            }
    }


