string number = Convert.ToString(new Random().Next(101,1000));
Console.Write($"Случайно число: {number}.\nЧисло без удалённой второй цифры:{number[0]}{number[2]}");
