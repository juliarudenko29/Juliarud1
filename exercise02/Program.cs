int max;

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    max = firstNumber;
}
else if (firstNumber < secondNumber)
{
    max = secondNumber;
}

if(secondNumber > thirdNumber)
{
    max = secondNumber;
}
else if (secondNumber < thirdNumber)
{
    max = thirdNumber;
Console.WriteLine("max = " + max.ToString() );
}



