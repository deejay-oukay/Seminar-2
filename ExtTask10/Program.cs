bool correct = false;


while(!correct)
    {
        Console.WriteLine("Введите логин из 5 букв: ");
        string login = Console.ReadLine();
        int symbols = 0;

        for (int i = 0; i < login.Length; i++)
            {
                if (char.IsLetter(login[i]))
                    symbols++;
            }

        if ((symbols == 5) && (login.Length == 5))
            correct = true;
        else
            Console.Write("Ошибка при вводе логина. ");

    }
Console.Write("Логин корректен. ");

correct = false;
while(!correct)
    {
        Console.WriteLine("Введите пароль из 6 и более цифр: ");
        string password = Console.ReadLine();
        int symbols = 0; //компилятор попросил повторное описание для этой переменной

        for (int i = 0; i < password.Length; i++)
            {
                if (char.IsNumber(password[i]))
                    symbols++;
            }

        if ((symbols > 6) && (password.Length == symbols))
            correct = true;
        else
            Console.Write("Ошибка при вводе пароля. ");
    }
Console.Write("Пароль корректен.");
