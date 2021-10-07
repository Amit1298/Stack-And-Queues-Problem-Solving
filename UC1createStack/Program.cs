using System;
using System.Collections;
using System.Collections.Generic;

namespace UC1createStack
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            LinkedListStack myNum = new LinkedListStack();
            myNum.Push(70);
            myNum.Push(30);
            myNum.Push(56);
            myNum.Display();
        }
    }
}
