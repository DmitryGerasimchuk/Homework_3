// Задача № 1:
// Напишите программу, 
// которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. 
// Проверка без применения строк.

// Проверка:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Числовой палиндром – это натуральное число,
// которое читается слева направо и справа налево одинаково. 
// Иначе говоря, отличается симметрией записи (расположения цифр), 
// причем число знаков может быть как четным, так и нечетным.

System.Console.WriteLine("Перед вами программа для определения числового палиндрома");

int Palindrome(string message) // Метод присвоения в переменную значение введенной строки в виде числа
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num) // Создание метода (функции), которая проверяет введеное число
{
    if (num >= 10000 && num <= 99999)
    {
        return true;
    }
    System.Console.WriteLine("Вы ввели не пятизначное число, поэтому программа не может быть исполнена.");
    return false;
}

int number = Palindrome("Введите любое положительное пятизначное число");

if (Validate(number)) // Условие проверки числа с использованием метода
{
    int firstNumber = number / 10000; // Нахождение первой цифры для проверки палиндрома
    int secondNumber = number / 1000 % 10; // Нахождение второй цифры для проверки палиндрома
    int fourthNumber = number / 10 % 10; // Нахождение четвертой цифры для проверки палиндрома
    int fifthNumber = number % 10; // Нахождение пятой цифры для проверки палиндрома

    if (firstNumber == fifthNumber && secondNumber == fourthNumber) // Условие проверки числового палиндрома
    {
        System.Console.WriteLine($"Введенное число {number} является числовым палиндром.");
    }
    else
    {
        System.Console.WriteLine($"Введенное число {number} не является числовым палиндром.");
    }
}