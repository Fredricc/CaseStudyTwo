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


        static void Main(string[] args)
        {

            Temp t = new Temp();

            //Console.WriteLine(t.num);
            int[] arr = { 8, 5, 4 };

            Array.Reverse(arr);

            double x = Math.Pow(arr[0], 2);
            Console.WriteLine(x);

        }
        class Temp
        {

            public int num = 2;

            public Temp() { num++; }

            ~Temp() { num++; }

        }
        class Clients
        {
            private string[] names = new string[10];

            public string this[int index]
            {
                get
                {
                    return names[index];
                }
                set
                {
                    names[index] = value;
                }
            }
        }
    }

    }