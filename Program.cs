// Task 2 Напишите программу которая на вход принимает два числа и 
// выдает какое из них меньше.

/*Console.WriteLine("Input a ferst number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 <= num2)
{
    
    Console.WriteLine("min num1:  " + num1);
}
else 
 {
    Console.WriteLine("max num2:  " + num2);
 }*/

 //Task 4 
 //Напишите программу, которая принимает на вход три числа 
 //и выдает из них максимальное.
/*
Console.WriteLine("Input a ferst number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a third number ");
int num3 = Convert.ToInt32(Console.ReadLine());
 
 int max = num1;
 if (num1 < num2)
 max = num2 ;
 if (num3 > max)
 max = num3;
 Console.WriteLine("Max  " + max);
*/

//Task 6
// Напишите программу которая на вход принимает число и выдает ,
// является ли число четным (делится ли оно на 2 без остатка.


/*Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2 == 0)
Console.WriteLine("Yes");
else
Console.WriteLine("No"); 
*/

//Task 8
// Напишите программу которая на вход принимает N, 
//а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
 int current = 1;

 while(current <= num)
 { if (current%2 == 0)
    {Console.WriteLine(current + " ");
    current++;}
    else
    {current++;}
 }