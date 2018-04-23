
using System;
using System.Collections.Generic;

namespace LinkedList
{

    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Prev { get; set; }
    }

    public class DoublyLinkedList<T> 
    {
          private LinkedListNode<T> head;
        private LinkedListNode<T> tail;

        public DoublyLinkedList()
        {
            tail = head = null;
        }

        public void Add(T data)
        {
            LinkedListNode<T> node = new LinkedListNode<T> {Data = data};
            Add(node);
        }

        private void Add(LinkedListNode<T> node)
        {
            if (tail != null )
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
        }
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
        }
        public LinkedListNode<T> Search(T value)
        {
            var result = head; //node cha
            var temp = head; //node chứa k nếu tìm thấy
            while ((temp != null) && (temp.Data.ToString() != value.ToString()))
            {
                result = temp;
                temp = temp.Next;
            }
            if (temp == null)
                result = null;
            return result;
        }

       
        
        public T Delete()
        {
            T retr;
            if (head != null)
            {
                retr = head.Data;
                head = head.Next;
                head.Prev = null;
            }
            else
            {
                retr = head.Data;
                head = null;
                tail = null;
            }

            return retr;
        }
       
        public void Delete(T value)
        {
            var temp = Search(value);
            if (temp.Next != null)
            {
                if (temp.Next.Next != null)
                {
                    temp.Next.Next = temp.Next.Next.Next;
                    if (temp.Next.Next.Next == null)
                    {
                        tail = temp.Next.Next;
                    }
                }

            }

        }


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