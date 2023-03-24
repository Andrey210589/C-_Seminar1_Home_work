// Task 2 Напишите программу которая на вход принимает два числа и 
// выдает какое из них меньше.

Console.WriteLine("Input a ferst number ");
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
 }