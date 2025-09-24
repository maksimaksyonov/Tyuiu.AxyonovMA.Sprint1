using Tyuiu.AxyonovMA.Sprint1.Task4.V8.Lib;

Console.Title = "Спринт #1 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
Console.WriteLine("* Формула: sqrt(|x-y| + 3x) / (3 + |x|)                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение x:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y:");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
var result = ds.Calculate(x, y);

Console.WriteLine("Результат вычисления: " + result);
Console.ReadKey();