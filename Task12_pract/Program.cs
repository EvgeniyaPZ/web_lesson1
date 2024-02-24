Console.WriteLine("Enter number");
int num1=Convert.ToInt32(Console.ReadLine());
//bool result = num1>=1000;
//if (1000<num1 && num1>=100)
 if (num1>=100 && num1<=999)
{
int a =num1%10;
int b = num1%100/10;
double result_f = Math.Pow(b,a);
Console.WriteLine(result_f);  
Console.WriteLine(b);
 Console.WriteLine(a); 

}
else {Console.Write("Число должно быть трехзначное");}
