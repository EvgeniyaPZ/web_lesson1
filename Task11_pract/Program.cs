Console.WriteLine("Enter number");
int num1=Convert.ToInt32(Console.ReadLine());
//bool result = num1>=1000;
//if (1000<num1 && num1>=100)
 if (num1>=100 && num1<=999)
{
int a =num1/100;
int b = num1%10;
//int result_f = num1%10+num1/100;
Console.Write(a);  
Console.Write(b); 
}
else {Console.Write("Число должно быть трехзначное");}
