using System.Collections;

namespace CaseStudyTwo
{
    internal class Program
    {
        //    static void Main(string[] args)
        //    {
        //        Box b1 = new Box(14, 3);
        //        Box b2 = new Box(5, 7);
        //        Box b3 = b1 + b2;

        //        Console.WriteLine(b3.Height);
        //        Console.WriteLine(b3.Width);
        //    }
        //}
        //class Box
        //{
        //    public int Height { get; set; }
        //    public int Width { get; set; }
        //    public Box(int h, int w)
        //    {
        //        Height = h;
        //        Width = w;
        //    }
        //    public static Box operator +(Box a, Box b)
        //    {
        //        int h = a.Height + b.Height;
        //        int w = a.Width + b.Width;
        //        Box res = new Box(h, w);
        //        return res;
        //    }
        //}


        //static void Main(string[] args)
        //{

        //    Temp t = new Temp();

        //    //Console.WriteLine(t.num);
        //    int[] arr = { 8, 5, 4 };

        //    Array.Reverse(arr);

        //    double x = Math.Pow(arr[0], 2);
        //    Console.WriteLine(x);

        //}
        //class Temp
        //{

        //    public int num = 2;

        //    public Temp() { num++; }

        //    ~Temp() { num++; }

        //}
        //class Clients
        //{
        //    private string[] names = new string[10];

        //    public string this[int index]
        //    {
        //        get
        //        {
        //            return names[index];
        //        }
        //        set
        //        {
        //            names[index] = value;
        //        }
        //    }
        //}
        static void Main(string[] args)
        {
            //int x = 0;
            //try
            //{
            //    x /= x;
            //    x += 1;
            //}
            //catch (Exception e)
            //{
            //    x += 3;
            //}
            //finally
            //{
            //    x += 4;
            //    Console.WriteLine(x);
            //}
            //List<int> li = new List<int>();
            //li.Add(59);
            //li.Add(72);
            //li.Add(95);
            //li.Add(5);
            //li.Add(9);
            //li.RemoveAt(1); // remove 72

            //Console.Write("\nList: ");
            //for (int x = 0; x < li.Count; x++)
            //    Console.Write(li[x] + " "); // 59  95  5  9
            //li.Sort();
            //Console.Write("\nSorted: ");
            //for (int x = 0; x < li.Count; x++)
            //    Console.Write(li[x] + " "); // 5  9  59  95

            //SortedList<string, int> pupil = new SortedList<string, int>();
            //pupil.Add("Bob", 11);
            //pupil.Add("Ann", 9);
            //pupil.Add("Mike", 12);
            //pupil.Remove("Ann");
            //foreach (string s in pupil.Keys)
            //    Console.WriteLine(s + ": " + pupil[s]);

            //BitArray ba1 = new BitArray(4);
            //BitArray ba2 = new BitArray(4);

            //ba1.SetAll(true);
            //ba2.SetAll(false);

            //ba1.Set(2, false);
            //ba2.Set(3, true);

            //PrintBarr("ba1", ba1);
            //PrintBarr("ba2", ba2);
            //Console.WriteLine();

            //PrintBarr("ba1 AND ba2", ba1.And(ba2));
            //PrintBarr("    NOT ba2", ba2.Not());

            //BitArray ba3 = new BitArray(4);
            //BitArray ba4 = new BitArray(4);
            //ba3.SetAll(true);
            //ba4.SetAll(false);
            //ba3.Set(2, false);
            //ba4.Set(3, true);
            //Console.Write(ba3.And(ba4).Get(3));

            //Stack<int> stk = new Stack<int>();

            //stk.Push(59);
            //stk.Push(72);
            //stk.Push(65);

            //Console.Write("Stack: ");
            //foreach (int i in stk)
            //{
            //    Console.Write(i + " ");  // 65  72  59
            //}
            //Console.Write("\nCount: " + stk.Count);  // 3

            //Console.Write("\nTop: " + stk.Peek());  // 65
            //Console.Write("\nPop: " + stk.Pop());  // 65

            //Console.Write("\nStack: ");
            //foreach (int i in stk)
            //    Console.Write(i + " ");  // 72  59
            //Console.Write("\nCount: " + stk.Count);  // 2

            //Queue<int> q = new Queue<int>();

            //q.Enqueue(5);
            //q.Enqueue(10);
            //q.Enqueue(15);
            //Console.Write("Queue: ");
            //foreach (int i in q)
            //    Console.Write(i + " ");  // 5  10  15
            //Console.Write("\nCount: " + q.Count);  // 3

            //Console.Write("\nDequeue: " + q.Dequeue()); // 5

            //Console.Write("\nQueue: ");
            //foreach (int i in q)
            //    Console.Write(i + " ");  // 10  15
            //Console.Write("\nCount: " + q.Count);  // 2

            //Queue<string> q = new Queue<string>();
            //q.Enqueue("A");
            //q.Enqueue("B");
            //q.Enqueue("C");
            //foreach (string s in q)
            //    Console.Write(s + " ");

            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Uno", 1);
            d.Add("One", 1);
            d.Add("Dos", 2);
            d.Add("Deux", 2);
            d.Remove("One");  // Remove key-value pair One, 1
            d.Remove("Dos");  // Remove key-value pair Dos, 2

            Console.WriteLine("Dictionary: ");
            foreach (string s in d.Keys)
                Console.WriteLine(s + ": " + d[s]);  // Uno: 1  Deux: 2
            Console.WriteLine("\nCount: {0}", d.Count); // 2 
        }

        static void PrintBarr(string name, BitArray ba)
        {
            Console.Write(name + " : ");
            for (int x = 0; x < ba.Length; x++)
                Console.Write(ba.Get(x) + " ");
            Console.WriteLine();
        }
    }
    public interface ISomeFunc
    {
        void Greet()
        {
            Console.Write("Hello!");
        }
    }
    class SomeObject : ISomeFunc
    {
        void Greet()
        {
            Console.Write("Hi!");
        }
    }
    class Stack<T>
    {
        int index = 0;
        T[] innerArray = new T[100];
        public void Push(T item)
        {
            innerArray[index++] = item;
        }
        public T Pop()
        {
            return innerArray[--index];
        }
        public T Get(int k) { return innerArray[k]; }
    }


}