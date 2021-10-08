using System;

namespace UC2PeekPopStack
{
    class UC2Program
    {
        static void Main(string[] args)
        {
            UC2LinkedListStack myNum = new UC2LinkedListStack();
            myNum.Push(70);
            myNum.Push(30);
            myNum.Push(56);
            myNum.Display();
            myNum.Peek();
            myNum.Pop();
            myNum.Display();
            myNum.IsEmpty();
            myNum.Display();
        }
    }
}

