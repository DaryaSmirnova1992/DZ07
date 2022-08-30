Console.WriteLine("Введите число A: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-> " + GetDegree(num));

double GetDegree(int number)
{
    double result = Math.Pow(num, num1);
    
    return result;
}