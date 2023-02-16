int max = 0;

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    max = firstNumber;
}
else if (firstNumber < secondNumber)
{
    max = secondNumber;
Console.WriteLine("max = " + max.ToString() );
} else {
    firstNumber = secondNumber;
    System.Console.WriteLine("числа равны");
}

