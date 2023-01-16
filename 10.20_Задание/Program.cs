Count();

int Sum(int x) 
{ 
    return x % 10 + x % 100 / 10 + x / 100; 
}
bool Equal(int x) 
{ 
    return Sum(x % 1000) == Sum(x / 1000); 
}
void Count()
{
    int count = 0;
    for (int i = 100000; i < 999999; i++)
if (Equal(i) == true)
{
    Console.WriteLine(i);
    count++;
}
    Console.WriteLine();
    Console.WriteLine($"Количество счастливых чисел: {count}");
    Console.ReadKey();
}