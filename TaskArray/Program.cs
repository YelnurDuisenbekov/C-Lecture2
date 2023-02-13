
// int [] array = {1,2,12,4,5,6,7,8,9};
// int s = array.Length;
// int i = 0;
// int max = array[i];
// for (i =0; i < s; i++)
// {
//     if (array[i] > max)
//     {
//        max = array[i];
//     }
// }
// Console.Write("Максимальное значение: " + max);

int [] array = {1,2,12,4,5,6,7,8,9};
int s = array.Length;
int i = 0;
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int find = number;
for (i =0; i < s; i++)
{
    if (array[i] == find)
    {
       Console.Write("Ваше значение под индексом: " + i);
    }
}
