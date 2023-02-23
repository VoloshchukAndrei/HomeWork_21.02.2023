Console.Clear();

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int resultA = numberA;

Console.Write($"Число A в натуральной степень числа B: {NaturalDegree(resultA)}");

int NaturalDegree(int resultA)
{
    resultA = numberA;
    for (int i = 1; i < numberB; i++)
    {
        resultA = resultA * numberA;
    }
    return resultA;
}