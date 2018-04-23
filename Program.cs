using System;

namespace LinkedList
{
    public class Prop
    {
        public int Val { get; set; }
        public override string ToString()
        {
            return Val.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList<int>();
            var t = new Prop{Val = 4};
           doublyLinkedList.AddFirst(2);
            doublyLinkedList.AddFirst(4);
            doublyLinkedList.AddFirst(42);
            doublyLinkedList.AddFirst(22);
            doublyLinkedList.Delete(42);
           doublyLinkedList.ShowAll();
        }
    }
}