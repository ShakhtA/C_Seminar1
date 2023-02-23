Console.Write("Введите целое число - ");
//string userInputStr = Console.ReadLine() ?? "";
//int userNumber = int.Parse(userInputStr);

int userNumber = int.Parse(Console.ReadLine() ?? ""); // int.Parse преобразует строковую переменную в целочисленную

int result = (int)Math.Pow(userNumber, 2);  //(int) явное преобразование в тип int
// библиотека Math возвращает все в вещественном типе double

Console.WriteLine($"{userNumber} -> {result}"); // вывод строки, заключенной в ""
Console.WriteLine(userNumber + " -> " + result);
