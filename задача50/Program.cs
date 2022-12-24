//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.
int m = 3;
int n = 3;
int [,] arr = new int [m,n];
Console.WriteLine("Введите значение: ");
int number = Convert.ToInt32(Console.ReadLine());
FillArray (arr);
FindElementArray(arr, number);

void FillArray(int [,] arrayTofill)
{
    for(int i = 0; i < arrayTofill.GetLength(0); i++)
    {
        for (int j = 0; j <  arrayTofill.GetLength(1); j++)
        {
            arr [i,j] = new Random().Next(1,10);
            Console.Write(arr [i,j] + " ");
        }
    }
}

void FindElementArray(int [,] findelement, int usernumber)
{
    bool find = false;
    for (int i = 0; i < findelement.GetLength(0); i++)
    {
        for(int j = 0; j < findelement.GetLength(1); j++)
        {
            if (findelement [i,j]== usernumber)
            Console.WriteLine("Ваше значение находится по координатам: " + i + " " +j);
        }
    }
    if (!find)
    Console.Write("Такого значения в массиве нет");
    Console.WriteLine();
}







