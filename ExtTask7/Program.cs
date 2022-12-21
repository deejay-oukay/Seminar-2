Console.Write("Введите слово, из которого иметь значение будет только первая буква: ");
string word = Console.ReadLine().Trim();

switch ($"{word[0]}")
{
    case "ф":
        Console.WriteLine("Физика");
        break;
    case "м":
        Console.WriteLine("Математика");
        break;
    case "и":
        Console.WriteLine("История");
        break;
    case "г":
        Console.WriteLine("География");
        break;
    case "б":
        Console.WriteLine("Биология");
        break;
    default:
        Console.WriteLine($"Для {word[0]} вариант не предусмотрен");
        break;
}