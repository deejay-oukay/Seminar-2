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
 
                switch (number)
                {
                    case 1:
                        Console.Write("Понедельник");
                        break;
                    case 2:
                        Console.Write("Вторник");
                        break;
                    case 3:
                        Console.Write("Среда");
                        break;
                    case 4:
                        Console.Write("Четверг");
                        break;
                    case 5:
                        Console.Write("Пятница");
                        break;
                    case 6:
                        Console.Write("Суббота");
                        break;
                    default:
                        Console.Write("Воскресенье");
                        break;
                }
 
                if (number > 5)
                    Console.WriteLine(" - Выходной день");
                else
                    Console.WriteLine(" - Рабочий день");
            }
    }


