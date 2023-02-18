Console.Write("Введите число: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());


for (int value = 1; value < maxNumber; value++)
{
    if (value % 2 == 0) {
     Console.Write($"{value} ");   
    }
}


