// Вывести на экран массив из 8 элементов
try
{
    int [] array = new int [8];
    for(int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Введите число с индексом  {i}");
        array[i] = int.Parse(Console.ReadLine());
        


    }
    for(int j = 0; j < 8; j++)
    {
        Console.Write($"{array[j]} ");
    }
}
catch
{
   Console.WriteLine("Не балуйтесь и вводите числа!");
 
}