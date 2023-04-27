// ************************************************************************************************************************************
//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = 0;
// Проверка пользователя на вшивость
while (number < 10000 || number > 99999) {
    // Ввод пользователем координат двух точек
    Console.WriteLine("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
// Находим количество единиц (n5), десятков (n4), сотен (n3), тысяч (n4), десятков тысяч (n5)
int n5 = number % 10;
int n4 = (number % 100) / 10;
int n3 = (number % 1000) / 100;
int n2 = (number % 10000) / 1000;
int n1 = (number % 100000) / 10000;
// Проверяем на полиндром
if (n5 == n1 && n4 == n2) Console.WriteLine($"Число {number} - полиндром");
else Console.WriteLine($"Число {number} - не полиндром");


// ************************************************************************************************************************************
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Ввод пользователем координат двух точек
Console.WriteLine("Введите координаты точки А: ");
Console.WriteLine("x1 = ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1 = ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1 = ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В: ");
Console.WriteLine("x2 = ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2 = ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1 = ");
double z2 = Convert.ToInt32(Console.ReadLine());

// Метод рассчёта расстояния между точками А и В
double FindDistance(double x1, double y1, double z1, 
                    double x2, double y2, double z2){
                        return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
                    }

Console.WriteLine($"Расстояние между точками равно {FindDistance(x1, y1, z1, x2, y2, z2)}");


// ************************************************************************************************************************************
// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int n){
    int i = 1;
    while (i <= n) {Console.Write($"{i}^3 = {Math.Round(Math.Pow(i, 3), 2)}, "); i++;}
}
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);