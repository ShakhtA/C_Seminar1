Console.Write("Введите два целых числа - ");
int numA = int.Parse(Console.ReadLine() ?? "");

//Console.Write("Введите целое число - ");
int numB = int.Parse(Console.ReadLine() ?? "");

if (numA == (numB*numB))
    {
        Console.WriteLine("Да");
    }
else 
    {
        Console.WriteLine("Нет");
    }


