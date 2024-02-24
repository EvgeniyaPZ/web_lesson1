Console.WriteLine("Enter number");
int num1=Convert.ToInt32(Console.ReadLine());
//bool result = num1>=1000;
if (1000<=num1) 
{
    Console.Write("Число должно быть трехзначное");
return;
}
if (num1<100)
{
    Console.Write("Число должно быть трехзначное");
return;
}
int a = num1/100;
int b = num1%10;
int result_f = a+b;
Console.WriteLine(result_f);
