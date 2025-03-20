
namespace SmallProjects;

class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);
        queue.Enqueue(60);
        queue.Dequeue();
        queue.PrintQueue();
        
        queue.PrintQueue();
    }
}

class Queue
{
    private int front;
    private int rear;
    private const int SIZE = 50;
    private int[] queueArray = new int[SIZE];
    
    public Queue()
    {
        front = -1;
        rear = -1;
    }

    public void Enqueue(int num)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is full");
            return;
        }
        if (IsEmpty())
        {
            front = 0;
        }
        queueArray[++rear] = num;
    }

    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        front++;
        if (front > rear)
        {
            front = rear = -1;
        }
    }

    public bool IsFull()
    {
        return rear == SIZE - 1;
    }

    public bool IsEmpty()
    {
        return front == -1;
    }

    public void PrintQueue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        Console.WriteLine("Elements in queue:");
        for (int i = front; i <= rear; i++)
        {
            Console.WriteLine(queueArray[i]);
        }
    }
}
