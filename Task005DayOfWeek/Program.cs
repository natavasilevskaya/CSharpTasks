// Программа принимает на вход число и по нему определеяет день недели(вывод значение в терминал)

Console.WriteLine("Input number 1-7: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1) Console.WriteLine("It is Monday!");
if (n == 2) Console.WriteLine ("It is Tuesday!");
if (n == 3) Console.WriteLine ("It is Wednesday!");
if (n == 4) Console.WriteLine ("It is Thursday!");
if (n == 5) Console.WriteLine ("It is Thursday!");
if (n == 6) Console.WriteLine ("It is Saturday!");
if (n == 7) Console.WriteLine ("It is Sunday!");
else Console.WriteLine("It is not correct number, input number in range 1-7");



