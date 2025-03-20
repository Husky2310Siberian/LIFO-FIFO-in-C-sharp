using System.Collections;

namespace LifoApp;

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
        stack.Push(60);
        stack.Pop();
        stack.PrintStack();

        Console.WriteLine("Element eliminated "+ stack.Pop());
        stack.PrintStack();
    }

    class Stack
    {
        private int top;
        private const int SIZE = 50;
        private int[] stackArray = new int[SIZE];

        public Stack()
        {
            
        }

        public void Push(int num)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            stackArray[++top] = num;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return stackArray[top--];
        }

        public bool IsFull()
        {
            return top == SIZE - 1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void PrintStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Elements in stack");
            for (int i = top; i >=0; i--)
            {
                Console.WriteLine(stackArray[i]);
            }
        }
    }
}