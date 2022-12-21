Console.Write("Введите слово, из которого иметь значение будет только первая буква: ");
string word = Console.ReadLine().Trim();

switch ($"{word[0]}")
{
    case "б":
        Console.WriteLine("Беларусь, Минск");
        break;
    case "р":
        Console.WriteLine("Россия, Москва");
        break;
    case "л":
        Console.WriteLine("Литва, Вильнус");
        break;
    default:
        Console.WriteLine($"Для {word[0]} вариант не предусмотрен");
        break;
}