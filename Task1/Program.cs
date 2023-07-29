Console.WriteLine("Введите массив чисел");
int[] mas = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Console.WriteLine($"Колличество всех элементов: {mas.Length} \nКолличество элементов > 0: {CountPolItem()}");

int CountPolItem()
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0)
        {
            count++;
        }
    }
    return count;
}