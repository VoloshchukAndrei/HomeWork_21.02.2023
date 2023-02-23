Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int N = number;

int[] array = ZeroOneArray(N);

Console.WriteLine($"[{String.Join(",", array)}]");

int[] ZeroOneArray (int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}