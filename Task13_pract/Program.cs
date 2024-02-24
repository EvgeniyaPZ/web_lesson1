Console.WriteLine("Enter number");
int num1=Convert.ToInt32(Console.ReadLine());
//bool result = num1>=1000;
//if (1000<num1 && num1>=100 )
 if (num1>=100 && num1<=999|| num1<= -100 && num1>=-999)
{
    
int a =num1/100; 
int b = num1%100/10;
bool result = a%b==0;

//double result_f = Math.Pow(b,a);
Console.WriteLine(result);  
//Console.WriteLine(b);
 //Console.WriteLine(a); 

}
else Console.WriteLine("error"); 