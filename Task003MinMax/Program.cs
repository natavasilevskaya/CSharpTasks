// Программа принимает на вход 2 числа и выводит в консоль какое число больше и какое меньше

void MinMaxNum (int n1, int n2)
{
    if (n1 > n2) Console.WriteLine($"{n1} bigger then {n2}");
    if (n1 < n2) Console.WriteLine($"{n2} bigger then {n1}");
    else Console.WriteLine($"{n1} is equal {n2}");
}


Console.WriteLine("Input number 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());

MinMaxNum(num1, num2);