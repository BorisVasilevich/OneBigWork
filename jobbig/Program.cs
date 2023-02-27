// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] masive1 = {"Hello", "2", "world", ":-)"};
string[] masive2 = {"1234", "1567", "-2", "computer science"};
string[] masive3 = {"Russia", "Denmark", "Kazan"};
string[] masive4 = {"Leo", "Max", "Boris", "Victor", "Kate", "Bob"};

string [] NewString(string [] array)
{
    int MinLength = 3;
    int Length = array.Length;
    string [] result = new string [array.Length];
    int count = 0;
    
    for (int i = 0;i < Length;i++)
    {
        if (array[i].Length <= MinLength)
        {
            result[count] = array[i];
            count++;
        }
    }    
    return result;
    } 

void PrintMasive(string [] mas)
{
    if (mas.Length == 0)
    {
        Console.WriteLine("Массив пустой");
    }
    else
    {
        int count = mas.Length;
        for (int i =0;i < count;i++)
        {
            Console.Write($" {mas[i]}");
        }
    }
    Console.WriteLine();
    
}


void PrintMassi(string [] massi)
{
Console.WriteLine("Исходный массив:");
PrintMasive(massi);
string [] outputmas = NewString(massi);
Console.WriteLine("Результирующий массив имеющий строки меньше либо равно 3 символам.");
PrintMasive(outputmas);
Console.WriteLine();
}
PrintMassi(masive1);
PrintMassi(masive2);
PrintMassi(masive3);
PrintMassi(masive4);


