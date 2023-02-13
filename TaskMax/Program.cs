int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
Console.Write("Введите 1 число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3 число: ");
int number3 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 4 число: ");
int number4 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 5 число: ");
int number5 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 6 число: ");
int number6 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 7 число: ");
int number7 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 8 число: ");
int number8 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 9 число: ");
int number9 = int.Parse(Console.ReadLine()!);

int max = Max(  Max (number1, number2, number3), 
                Max (number4, number5, number6),
                Max ( number7, number8, number9));
Console.Write("Максимальное значение: " + max);