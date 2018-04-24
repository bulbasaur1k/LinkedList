using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace LinkedList
{
    //Элемент списка
    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Prev { get; set; }
    }

    public class DoublyLinkedList<T>
    {
        //голова списка
        private LinkedListNode<T> head;

        //хвост списка
        private LinkedListNode<T> tail;

        private int count;

        public string Count => count.ToString();

        //конструктор создает null по умолчанию
        public DoublyLinkedList()
        {
            tail = head = null;
        }

        //создается элемент списка и отправляется в метод Add
        public void Add(T data)
        {
            LinkedListNode<T> node = new LinkedListNode<T> {Data = data};
            Add(node);
        }

        //Добавляет элемент в конец списка
        private void Add(LinkedListNode<T> node)
        {
            if (tail != null)
            {
                node.Prev = tail;
            }

            if (head != null)
            {
                tail.Next = node;
            }
            else
            {
                head = node;
            }

            tail = node;
            count++;
        }

        //добавляет элемент в начало списка
        public void AddFirst(T value)
        {
            if (head == null)
            {
                head = tail = new LinkedListNode<T> {Data = value};
            }
            else
            {
                LinkedListNode<T> temp = head;
                head = new LinkedListNode<T> {Data = value};
                temp.Prev = head;
                head.Next = temp;
            }

            count++;
        }

        //Удаляет следующее значение после выбранного
        public void DeleteNext(int value)
        {
            var temp = head;

            if (value > count)
            {
                Console.WriteLine("Заданное значение больше чем максимальное");
                return;
            }

            if (value > 0)
            {
                for (int i = 1; i < value; i++)
                {
                    temp = temp.Next;
                }
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Нету следующего элемента списка");
                return;
            }

            if (temp.Next.Next != null)
            {
                temp.Next = temp.Next.Next;
            }
            else
            {
                temp.Next = null;
                tail = temp;
            }

            count--;
        }

        //вывести все значения
        public void ShowAll()
        {
            LinkedListNode<T> tempListNode = head;
            Console.Write("{");
            while (tempListNode != null)
            {
                if (tempListNode.Next != null)
                {
                    Console.Write("{0},", tempListNode.Data.ToString());
                }
                else
                {
                    Console.Write("{0}", tempListNode.Data.ToString());
                }

                tempListNode = tempListNode.Next;
            }

            Console.WriteLine("}");
        }
    }
}