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


int randomNumber = new Random().Next(20,100);
Console.WriteLine($"Случайно число: {randomNumber}");
int keyboardNumber = Input("Введите целое число: ");
Console.WriteLine((randomNumber) + (randomNumber % keyboardNumber == 0 ? "" : " НЕ") + " делится на " + keyboardNumber);
