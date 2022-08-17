// Возводим число А в натуральную степень числа B
Console.WriteLine("Введите число А");
try
{
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int B = int.Parse(Console.ReadLine());

    int degree = 1;

    for(int i = 1; i <= B; i++)
    {
        degree = degree * A;
        
    }
    Console.WriteLine(degree);
}

catch
{
    System.Console.WriteLine("это не число");
}

