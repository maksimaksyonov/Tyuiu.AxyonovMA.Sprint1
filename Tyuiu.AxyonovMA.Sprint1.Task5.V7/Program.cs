using Tyuiu.AxyonovMA.Sprint1.Task5.V7.Lib;

Console.Title = "Спринт #1 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до     *");
Console.WriteLine("* того момента (в первой половине дня), когда часовая стрелка повернулась *");
Console.WriteLine("* на f градусов (0<f<360, f – вещественное число).                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите угол поворота часовой стрелки f (0 < f < 360):");
double f = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
var result = ds.AngleToHours(f);

Console.WriteLine("Количество прошедших часов: " + result);
Console.ReadKey();