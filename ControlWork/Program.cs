//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых равна или меньше 3. Первоначальный массив вводится с клавиатуры

Console.WriteLine("Введите количество элементов в массиве ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = MassElems(size);
MassOfElemsLessThanFour(array, size);
//----------------Методы---------------//

string[] MassElems(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void MassOfElemsLessThanFour(string[] arr, int size)
{
    string[] changedArray = new string[size];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length <= 3)
        {
            changedArray[j] = arr[i];
            Console.Write($"{changedArray[j]}");
            Console.Write(" ");
            j++;
        }
    }
}