int Input(string message)
    {
        int number = 0;
        while(number == 0)  //попутно избегаем деления на 0
            {
                Console.Write(message);
                string testNumber = Console.ReadLine().Trim();
                if (!int.TryParse(testNumber,out number))
                    Console.Write("Вы ввели не число. ");
                else
                    {
                        //здесь можно было сразу использовать return, но компилятор преполагает, что "не все пути к коду возвращают значение"
                    }
            }
        return number;
    }

int modulo = Input("Введите первое число: ")%Input("Введите второе число: ");

Console.WriteLine(modulo == 0 ? "Кратно" : $"НЕ кратно. Остаток {modulo}");


