using System;

namespace LinkedList.Models
{
    public class DLL
    {
        public DLNode Head;
        public DLNode Tail;
        public int Count;
        public DLL()
        {
            Tail = null;
            Head = null;
            Count = 0;
        }
        public void PushBack(int val)
        {
            DLNode newNode = new DLNode(val);
            if (Head == null)
            {
                Tail = newNode;
                Head = newNode;
                Count += 1;
            }
            else
            {
                Count += 1;
                Tail.Next = newNode;
                newNode.Prev = this.Tail;
                Tail = newNode;
            }
        }
        public void RemoveLast()
        {
            if(Head == Tail){
                Console.WriteLine("I aint got no tail");
            }
            else{
                DLNode temp = Tail.Prev;
                Console.WriteLine(temp.Value);
                Tail.Prev = null;
                Tail = temp;
                Tail.Next = null;
                Count -= 1;
            }
        }
        
        public int Size()
        {
            var num = Count;
            return num;
        }
        public void Print(){
            var runner = Head;
            while (runner != null)
            {
                Console.Write($"{runner.Value}, ");
                runner = runner.Next;
            }
        Console.WriteLine("");
        }
    }
}
