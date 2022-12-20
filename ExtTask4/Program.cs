int Input(string message)
    {
        int number = 0;
        while(number == 0)
            {
                Console.Write(message);
                string testNumber = Console.ReadLine().Trim();
                if (!int.TryParse(testNumber,out number))
                    Console.Write("Вы ввели не число. ");
                else if (number < 1 || number > 12)
                    Console.Write("Вы ввели некорректное число. ");
                else
                    {}
            }
        return number;
    }


int month = Input("Введите номер месяца (от 1 до 12): ");
if (month == 12 || month < 3)
    Console.WriteLine("Зима");
else if (month < 6)
    Console.WriteLine("Весна");
else if (month < 9)
    Console.WriteLine("Лето");
else
    Console.WriteLine("Осень");

//Про сессию, каникулы и семестры не понял. Да, и дат их не знаю :-)