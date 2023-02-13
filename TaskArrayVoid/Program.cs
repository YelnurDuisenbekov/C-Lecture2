Console.Write("Введите максимальное число количества чисел в массиве: ");
int a = int.Parse(Console.ReadLine()!);
void FillArray(int[] array)
{
    int lenght = array.Length;
    int i = 0;
    for (i=0; i<lenght; i++)
    {
        array[i] = new Random().Next(1,a);
    }
}
void PrintArray(int[] array)
{
    int lenght = array.Length;
    int i = 0;
    
    for (i=0; i<lenght; i++)
    {
        Console.WriteLine(array[i]);
    }
}
int[] array = new int [a];
FillArray(array);
PrintArray(array);

Console.Write("Введите число которое ищите: ");
int find = int.Parse(Console.ReadLine()!);
int s = array.Length;
int i = 0;
for (i =0; i < s; i++)
{
    if (array[i] == find)
    {
       Console.WriteLine("Ваше значение под индексом: " + i);
    }
}