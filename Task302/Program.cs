// Задача № 2:
// Напишите программу,
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Проверка:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Перед вами программа для нахождения расстояния между точками в 3D пространстве");

int InputInt(string message) // Метод проверки на "кривой" ввод
{
    System.Console.Write($"{message} > "); // Запрос ввода данных
    int value; // Инициализация переменной 
    bool isCorrect = int.TryParse(Console.ReadLine(), out value); // Конвертация строки в цифру и проверка условия корректности ввода
    if (isCorrect) // Провека условия ввода данных
    {
        return value; // Если ввели число (int), то идем дальше по программе
    }
    System.Console.WriteLine("Вы ввели не число!"); // Если введи не число (поэтому не стробатало TryParse), то выводится сообщение
    Environment.Exit(1);
    return 0; // После вывода сообщения, программа ничего не ищет и не вычисляет
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)// Метод поиска расстояния между двумя точками
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ); 
}
// Ввод данных двух точек поочередно
int x1 = InputInt("Введите координату х точки А");
int y1 = InputInt("Введите координату у точки А");
int z1 = InputInt("Введите координату z точки А");
int x2 = InputInt("Введите координату х точки B");
int y2 = InputInt("Введите координату у точки B");
int z2 = InputInt("Введите координату z точки B");

double distance = Distance(x1, y1, z1, x2, y2, z2); // Обращение к методу нахождения расстояния 
System.Console.WriteLine($"Расстояние между точками А с координатами ({x1}, {y1}, {z1}) и В с координатами ({x2}, {y2}, {z2}) равно {distance:F2}."); // Вывод значения с двумя знакоми после запятой