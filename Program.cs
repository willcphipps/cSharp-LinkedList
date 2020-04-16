using System;
using LinkedList.Models;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // SLL list = new SLL();
            // list.AddBack(3);
            // list.AddBack(9);
            // list.AddBack(6);
            // list.AddBack(5);
            // list.AddBack(3);
            // list.AddBack(9);
            // list.AddBack(6);
            // list.AddBack(5);
            // Console.WriteLine(list.Count);
            // list.Print();
            // var variable = list.Head.Next.Next.Next.Next.Next.Next;
            // variable.Next = list.Head.Next;
            // list.Print();

            // SLL child = new SLL();
            // child.AddBack(14);
            // child.AddBack(18);
            // child.AddBack(13);
            // list.AddChild(child,9);
            // list.FlattenChildren();
            // list.Print();
            // list.UnflattenChildren();
            // list.Print();

            DLL dlist = new DLL();
            dlist.PushBack(1);
            dlist.PushBack(2);
            dlist.PushBack(5);
            dlist.PushBack(5);
            dlist.PushBack(1);
            dlist.RemoveLast();
            dlist.Print();



        }
    }
}
