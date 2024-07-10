Console.WriteLine("Введите вес в килограммах: ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите рост в метрах: ");
double height = Convert.ToDouble(Console.ReadLine());

double yourBMI = weight / (height * height);
Console.WriteLine($"Ваш индекс массы тела: {yourBMI:F1}");

if (yourBMI < 16)
{
    Console.WriteLine("У вас выраженный дефецит массы тела!");
}
if (yourBMI >= 16 & yourBMI <= 17.9)
{
    Console.WriteLine("У вас недостаточная масса тела!");
}
if (yourBMI >= 18 & yourBMI <= 24.9)
{
    Console.WriteLine("У вас нормальный вес!");
}
if (yourBMI >= 25 & yourBMI <= 29.9)
{
    Console.WriteLine("У вас избыточная масса тела!");
}
if (yourBMI >= 30 & yourBMI <= 34.9)
{
    Console.WriteLine("У вас ожирение 1 степени!");
}
if (yourBMI >= 35 & yourBMI <= 39.9)
{
    Console.WriteLine("У вас ожирение 2 степени!");
}
if (yourBMI >= 40)
{
    Console.WriteLine("У вас ожирение 3 степени!");
}
Console.ReadLine();