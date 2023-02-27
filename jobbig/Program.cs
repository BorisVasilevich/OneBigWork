// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] masive1 = {"Hello", "2", "world", ":-)"};
string[] masive2 = {"1234", "1567", "-2", "computer science"};
string[] masive3 = {"Russia", "Denmark", "Kazan"};

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



