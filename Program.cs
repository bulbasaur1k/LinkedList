using System;
using System.Numerics;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList<int>();

            Console.WriteLine("Создана коллекция, пожалуйста введите значение типа int для добавления в начало списка:");
            var str = Console.ReadLine();
            //Заполнение
            while (true)
            {
                if (str == "w" || str == "q")
                {
                    break;
                }
                if (str == "c")
                {
                    Console.WriteLine(doublyLinkedList.Count);
                }
                if (str == "s")
                {
                    doublyLinkedList.ShowAll();
                }

               
                
                try
                {
                    doublyLinkedList.AddFirst(Convert.ToInt32(str));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Введенное значение не является командой или типом Int");
                }

                Console.WriteLine("Выход: q, Продолжить: w, Показать количество элементов: c, вывести все значения: s , Введите значение ");
                str = Console.ReadLine();
            }

            Console.WriteLine("Введите номер элемента, после которого удалить значение");
            str = Console.ReadLine();
            //Удаление
            while (true)
            {
                if (str == "q")
                {
                    break;
                }
                if (str == "c")
                {
                    Console.WriteLine(doublyLinkedList.Count);
                }

                if (str == "s")
                {
                    doublyLinkedList.ShowAll();
                }
                try
                {
                    doublyLinkedList.DeleteNext(Convert.ToInt32(str));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Введенное значение не является командой или типом Int");
                }
                Console.WriteLine("Выход: q,  Показать количество элементов: c, вывести все значения: s , Введите значение после которого удалить");
                str = Console.ReadLine();
            }

            Console.WriteLine("Программа завершена");
            Console.ReadLine();
        }
    }
}