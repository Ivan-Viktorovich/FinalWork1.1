//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//<= 3 символа. Первоначальный массив можно ввести с клавиатуры пользователем. Лучше использовать массивы,
// а не коллекции.
void FillingTheArray (string[] array)
{
    Console.WriteLine("Введите число, слово, символы: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToString(Console.ReadLine());
    }
    Console.WriteLine("Ваш массив: [" + string.Join(", ", array) + "]");
    return;
}
Console.WriteLine("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] array = new string[N];
FillingTheArray(array);
string[] newarr = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        newarr[i] = array[i];
    }
}
Console.WriteLine("Ваш новый массив: ["+ string.Join(" ", newarr) + " ]");