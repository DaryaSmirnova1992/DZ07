
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-> "+GetSum(num));

int GetSum(int number)
{
 int count =0;
 int sum =0;
 while(number>0)
 {
    int num1 = number % 10;
     sum = sum + num1;
		count++;
		number/=10;
 }
	return sum;

}
