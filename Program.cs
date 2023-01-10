Console.WriteLine("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] Array = new string [size];
for (int i = 0; i < Array.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i} :\t");
    Array[i] = Convert.ToString(Console.ReadLine());

}
Console.WriteLine("Вывод массива: ");
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
        Console.WriteLine($" {Array[i]} ");
}
