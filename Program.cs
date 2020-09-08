using System;
using System.Text;

namespace hienthi20songuyentodautien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("20 số nguyên tố đầu tiên là:");
            int index = 0;
            for (int i = 2; i < 200; i++)
            {
                bool check = true;
                for (int count = 2; count <= Math.Sqrt(i); count++)
                {
                    if (i % count == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    index = index + 1;
                    if (index <= 20)
                    {
                        Console.WriteLine(i + "\t");
                    }
                }
            }
        }
    }
}