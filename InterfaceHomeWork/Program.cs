using System;

namespace InterfaceHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int> myList = new MyList<int>(0);

            const int sizeArray = 4;
            for (int i = 0; i < sizeArray; i++)
            {
                myList.Add(i);
            }


            Console.WriteLine("Элементы массива:");
            for (int i = 0;i< myList.Length(); i++)
            {
                Console.Write($"{myList[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Элемент 2 содержится в myList = {myList.Contains(2)}");


            MyList<int> newList = new MyList<int>(0);

            newList.CopyTo(myList._array, 1);
            Console.WriteLine("Элементы нового массива: ");
            for (int i = 0; i < newList.Length(); i++)
            {
                Console.Write($"{newList[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Индекс элемента 1 = {myList.IndexOf(1)}");

            Console.WriteLine("Внесение в 0 позицию числа 7:");
            myList.Insert(0, 7);
            for (int i = 0; i < myList.Length(); i++)
            {
                Console.Write($"{myList[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Удаление элемента с позиции 1:");
            myList.RemoveAt(1);
            for (int i = 0; i < myList.Length(); i++)
            {
                Console.Write($"{myList[i]} ");
            }
            Console.WriteLine();


            Console.WriteLine("Удаление элемента 7");
            myList.Remove(7);
            for (int i = 0; i < myList.Length(); i++)
            {
                Console.Write($"{myList[i]} ");
            }
            Console.WriteLine();


            myList.Clear();
            Console.WriteLine($"Длина массива после удаления = {myList.Length()}");

            Console.WriteLine();
        }
    }
}
