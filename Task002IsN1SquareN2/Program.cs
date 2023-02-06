// Программа принимает на вход 2 числа и проверяет, является ли 1-е квадратом 2-го

bool IsSquareNum (int a, int b)
{
    int square = b * b;
    if(a == square)
    {
        return true;
    }
    return false;
}

Console.WriteLine("Input number 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquareNum(num1, num2));
