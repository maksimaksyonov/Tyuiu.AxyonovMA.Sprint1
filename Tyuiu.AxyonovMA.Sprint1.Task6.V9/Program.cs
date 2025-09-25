using Tyuiu.AxyonovMA.Sprint1.Task6.V9.Lib;

Console.Title = "Спринт #1 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Работа со строками                                                *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова,    *");
Console.WriteLine("* перенеся их последнюю букву в начало.                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите текст:");
string inputText = Console.ReadLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string result = ds.MoveLastLetterToStart(inputText);

Console.WriteLine("Результат:");
Console.WriteLine(result);
Console.ReadKey();