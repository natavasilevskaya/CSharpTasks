﻿// Программа принимает на вход числ в десятиричной системе исчисления и переводит его в двоичную систему

string ChangeNumber (int number)
{
    string result = string.Empty; //аналогично кавычкам

    while(number >=1)
    {   
        result += number%2 + result;  // остатки будут записываться слева, а не справа = конкатинация - не придется переворачивать
        number /=2; // аналогично number / 2
    }

    return result;
}

// чтобы перевести число из одной системы исчисления в другую - нужно делить число на число желаемой степени исчисления - делить на 2
// и чиксировать остатки, пока число не окажется меньше 2 - и его тоже поделить на 2
