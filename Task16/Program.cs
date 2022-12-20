int Input(string message)
    {
        int number = 0;
        while(number == 0)  //попутно избегаем деления на 0
            {
                Console.Write(message);
                string testNumber = Console.ReadLine().Trim();
                if (!int.TryParse(testNumber,out number))
                    Console.Write("Вы ввели не число или некорректное число. ");
                else
                    {
                        //здесь можно было сразу использовать return, но компилятор преполагает, что "не все пути к коду возвращают значение"
                    }
            }
        return number;
    }

int first = Input("Введите первое число: ");
int second = Input("Введите второе число: ");

if (Math.Pow(first,2) == second)
    Console.WriteLine("Да, второе число является квадратом первого");
else if (Math.Pow(second,2) == first)
    Console.WriteLine("Да, первое число является квадратом второго");
else
    Console.WriteLine("Нет, ни одного число не является квадратом другого");


