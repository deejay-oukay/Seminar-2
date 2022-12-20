int Input(string message)
    {
        int number = 0;
        while(number == 0)
            {
                Console.Write(message);
                string testNumber = Console.ReadLine().Trim();
                if (!int.TryParse(testNumber,out number))
                    Console.Write("Вы ввели не число или некорректное число. ");
                else
                    {}
            }
        return number;
    }


int height = Input("Введите рост в см.: ");
int weight = Input("Введите вес в кг.: ");
double tenPersent = Convert.ToDouble(height)/10;
double normaMin = Convert.ToDouble(height) - 100 - tenPersent;
double normaMax = Convert.ToDouble(height) - 100 + tenPersent;

Console.WriteLine($"10% от роста {height} это {tenPersent}");
Console.WriteLine($"При росте {height} см. нормальный вес должен быть в пределах {normaMin} и {normaMax} кг.");

if (normaMax < Convert.ToDouble(weight))
    Console.WriteLine("Вам нужно похудеть");
else if (normaMin > Convert.ToDouble(weight))
    Console.WriteLine("Вам нужно поправиться");
else
    Console.WriteLine("У Вас норма");
