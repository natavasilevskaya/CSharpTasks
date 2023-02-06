// Программа принимает на вход число, возводит его в квадрат и выводит в терминал

int SqureOfNum(int n)
{
    int square = n * n;
    return square;
}

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Square of {num} is {SqureOfNum(num)}");