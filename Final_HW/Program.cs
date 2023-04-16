
Console.Clear();

string[] stringArray;
string[] correctArray;

Console.WriteLine("Введите элементы массива через пробел: ");

stringArray = InputElements(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
Console.WriteLine($"[{string.Join(", ", stringArray)}]");

correctArray = FillArrary(stringArray);
Console.WriteLine($"[{string.Join(", ", correctArray)}]");

string[] InputElements(string[] array)
{
    if (IsEmptyArray(array)) return array;
    else
    {
        Console.WriteLine("Вы ничего не ввели, пожалуйста повторите: ");
        return InputElements(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
    }
}

bool IsEmptyArray(string[] arr)
{
    if (arr == null || arr.Length == 0) return false;
    return true;
}

string[] FillArrary(string[] array)
{
    int count = 0;

    foreach (string element in array)
    {
        if (element.Length <= 3) count++;
    }

    string[] result = new string[count];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i]; j++;
        }
    }
    return result;
}
