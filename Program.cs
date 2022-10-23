// Напишите программу, которая принимает трехзначное число и на выходе показывает вторую цифру этого число 
int N = 0;
Console.WriteLine("Input a three-digit number");
N = Convert.ToInt32(Console.ReadLine());
if (N >= 100 && N <= 999)
{
    int DivideByTen = N / 10;
    int LastDigit = DivideByTen % 10;
    Console.WriteLine("The second digit is " +LastDigit);
}
else
{
    Console.WriteLine("Not suitable");
}